using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    public GameObject mapa;
    public GameObject player;

    
    public GameObject cacto;
    public GameObject cacto2;
    public GameObject cacto3;
    public GameObject passaro;



    private bool gerandoCacto1 = false; // Controle para o cacto1
    private bool gerandoCacto2 = false; // Controle para o cacto2
    private bool gerandoCacto3 = false; 
    private bool gerandoCacto4 = false; 



    public float tempo;
    public float tempo2;
    public float tempo3;
    public float tempo2completo;
    public float coldow_gerador;
    public float delete_object;

    public static bool start;
    public bool delete_triger;

    public Vector3 playerposição;
    public Vector3 frenteplayer;
    public Vector3 passaroposiçao;

    public float playerposiçãox;
    public int GERADORDEOBJETOS;


    void Update()
    {
        tempo2completo = tempo2 * tempo2;

        if (start == true)
        {
            player.transform.Translate((20 + (2/ tempo2)) * Time.deltaTime, 0, 0);
            mapa.transform.Translate((20 + (2 /tempo2)) * Time.deltaTime, 0, 0);
        }

        if (start == true)
        {
            tempo = tempo + -3 * Time.deltaTime;
            tempo2 = tempo2 + 3 * Time.deltaTime;
            
        }

       

       Vector3 playerposição = player.transform.position;

        



        if (start == true)
        {
            tempo3 = tempo3 +1 * Time.deltaTime;
            coldow_gerador = coldow_gerador + 1 * Time.deltaTime;
        }
        if (tempo3 > 1.5)
        {
            GERADORDEOBJETOS = Random.RandomRange(1, 5);
            
        }
        if (tempo3 > 1.6)
        {
            tempo3 = 0;
            coldow_gerador = 0;
        }
       

        if (delete_triger == true)
        {
            delete_object = delete_object + 1 * Time.deltaTime;
        }
        else
        {
            delete_object = 0;
        }



        

        frenteplayer = transform.position = new Vector3(playerposição.x + 80, 1, playerposição.z);
        passaroposiçao = transform.position = new Vector3(playerposição.x + 80, (float)4.30, playerposição.z);

        if (start && GERADORDEOBJETOS == 1 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto1)
        {
            gerandoCacto1 = true;
            Instantiate(cacto, frenteplayer, Quaternion.identity);
            delete_triger = true;
        }
        else if (start && GERADORDEOBJETOS == 2 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto2)
        {
            gerandoCacto2 = true;
            Instantiate(cacto2, frenteplayer, Quaternion.identity);
            delete_triger = true;
        }
        else if(start && GERADORDEOBJETOS == 3 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto3)
        {
            gerandoCacto3 = true;
            Instantiate(cacto3, frenteplayer, Quaternion.identity);
            delete_triger = true;
        }
        else if (start && GERADORDEOBJETOS == 4 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto4)
        {
            gerandoCacto4 = true;
            Instantiate(passaro, passaroposiçao, Quaternion.identity);
            delete_triger = true;
        }




        if (gerandoCacto1 == true && delete_object > 2)
        {
            gerandoCacto1 = false;
            delete_triger = false;
        }
        if (gerandoCacto2 == true && delete_object > 2)
        {
            gerandoCacto2 = false;
            delete_triger = false;
        }
        if (gerandoCacto3 == true && delete_object > 2)
        {
            gerandoCacto3 = false;
            delete_triger = false;
        }
        if (gerandoCacto4 == true && delete_object > 2)
        {
            gerandoCacto4 = false;
            delete_triger = false;
        }







    }


   

    public void começo()
    {
        start = true;
    }
}
