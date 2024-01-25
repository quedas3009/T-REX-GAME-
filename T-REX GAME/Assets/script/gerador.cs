using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gerador : MonoBehaviour
{
    public GameObject mapa;
    public GameObject player;

    public GameObject menufist;
    public GameObject tuturial;

    public GameObject exit;
    public GameObject exitmenu;
    public GameObject exit2;
    public GameObject exit3;
    public GameObject exit4;
    public GameObject exit5;


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
    public Vector3 passaroposiçao3;
    public Vector3 passaroposiçao2;
    public float playerposiçãox;
    public int GERADORDEOBJETOS;

    public float timer_forfast;
    public float dobrarpelotempo;

    void Update()
    {

        
        

        tempo2completo = tempo2 * tempo2;

        if (start == true)
        {
            player.transform.Translate((-40  * Time.deltaTime) * dobrarpelotempo, 0, 0);
            mapa.transform.Translate((40   * Time.deltaTime)*dobrarpelotempo, 0, 0);



            timer_forfast = timer_forfast + 1 * Time.deltaTime;
            dobrarpelotempo = timer_forfast / 4;

            menu.firstmenuon = true;





            tempo = tempo + -3 * Time.deltaTime;
            tempo2 = tempo2 + 3 * Time.deltaTime;
        }
        if (start == false)
        {
            dobrarpelotempo = 0;
            timer_forfast = 0;
        }
        if (dobrarpelotempo > 3.7)
        {
            dobrarpelotempo = 3;

        }
        if (points.poinst > 25)
        {
            dobrarpelotempo = 4;
        }

        Vector3 playerposição = player.transform.position;





        if (start == true)
        {
            tempo3 = tempo3 + 1 * Time.deltaTime;
            coldow_gerador = coldow_gerador + 1 * Time.deltaTime;
        }
        if (tempo3 > 1.5)
        {
            GERADORDEOBJETOS = Random.RandomRange(1, 6);

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


      


        frenteplayer = transform.position = new Vector3(playerposição.x + 100, 1, playerposição.z);
        passaroposiçao = transform.position = new Vector3(playerposição.x + 100, 6, playerposição.z);
        passaroposiçao2 = transform.position = new Vector3(playerposição.x + 100, 4, playerposição.z);
        passaroposiçao3 = transform.position = new Vector3(playerposição.x + 100, 5, playerposição.z);

        if (start==true  && GERADORDEOBJETOS == 1 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto1)
        {
            gerandoCacto1 = true;
            GameObject clone = Instantiate(cacto, frenteplayer, Quaternion.identity);
            clone.tag = "morte";
            delete_triger = true;
           
        }
        else if (start==true && GERADORDEOBJETOS == 2 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto2)
        {
            gerandoCacto2 = true;
            Instantiate(cacto2, frenteplayer, Quaternion.identity);
            delete_triger = true;
        }
        else if (start==true && GERADORDEOBJETOS == 3 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto3)
        {
            gerandoCacto3 = true;
            Instantiate(cacto3, frenteplayer, Quaternion.identity);
            delete_triger = true;
        }
        else if (start== true && GERADORDEOBJETOS == 4 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto4)
        {
            gerandoCacto4 = true;
            GameObject clone1 = Instantiate(passaro, passaroposiçao, Quaternion.identity);
            clone1.tag = "morte";
            delete_triger = true;

        }
        else if (start == true && GERADORDEOBJETOS == 5 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto4)
        {
            gerandoCacto4 = true;
            GameObject clone1 = Instantiate(passaro, passaroposiçao2, Quaternion.identity);
            clone1.tag = "morte";
            delete_triger = true;

        }
        else if (start == true && GERADORDEOBJETOS == 6 && coldow_gerador >= 1 && coldow_gerador <= 1.1 && !gerandoCacto4)
        {
            gerandoCacto4 = true;
            GameObject clone1 = Instantiate(passaro, passaroposiçao3, Quaternion.identity);
            clone1.tag = "morte";
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


        player.transform.position = new Vector3(playerposição.x, playerposição.y, 0);

    }




    public void começo()
    {
        menufist.SetActive(false);
        start = true;

        menu.firstmenuon = true;
    }



    public void tuturial_abrir()
    {
        tuturial.SetActive(true);
        menu.firstmenuon = false;
        menu.tuturialmenuon = true;
    }
    public void tuturial_fechar()
    {
        menu.tuturialmenuon = false;
        menu.firstmenuon = true;
        tuturial.SetActive(false);
    }



    public void exitmenu1()
    {
        Application.Quit();
    }
    /*
    public void exit_0()
    {
        exit.SetActive(false);
        exit2.SetActive(true);
    }
    public void exit_1()
    {
        exit2.SetActive(false);
        exit3.SetActive(true);
    }
    public void exit_2()
    {
        exit3.SetActive(false);
        exit4.SetActive(true);
    }
    public void exit_3()
    {
        tr
    }
    */
}
