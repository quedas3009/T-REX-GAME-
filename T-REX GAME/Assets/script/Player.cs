using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //gameObjetos do jogo e configura�oes para os gameobjects
    public GameObject pp;
    public Rigidbody rb;
    public GameObject map;

    public AudioSource jump;

    public float jumpforce;

   

    public bool nochau;
    public static bool morreu;
   

    private float zposi��o;
    private float yposi��o;
    private float xposi��o;


    public bool salto;





    
    void Update()
    {
        //jump
        if ( Input.GetKey(KeyCode.Space) && nochau==true && gerador.start)
        {
            salto = true;
            


            
                jump.Play();
                
            


        }
        else if(nochau == false)
        {
            rb.AddForce(0, -15, 0, ForceMode.Force);
            salto = false;
        }


        if (salto == true && nochau==true && gerador.start ==true)
        {
            rb.AddForce(0, (float)jumpforce, 0, ForceMode.Impulse);
        }




        //ir para baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            rb.AddForce(0, -3, 0, ForceMode.Force);
        }


       





        Vector3 playerposi��o = pp.transform.position;


        xposi��o = playerposi��o.x;
        yposi��o = playerposi��o.y;
        zposi��o = playerposi��o.z;


        
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            
            nochau = true;
        }

        if (other.gameObject.tag == "morte")
        {

            morreu = true;
            menu.deathmenuon = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            
            nochau = false;
        }
    }

   




}
