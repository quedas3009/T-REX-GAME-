using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlo_pp : MonoBehaviour
{
    public GameObject pp;
    public Rigidbody rb;

    public float contador_salto;
    public bool ativa_contador;


    public bool cold_down = false;
    public float contador_cold_down;
    public bool salto;
    void Update()
    {
        //------SALTAR-----------------------------
        if (Input.GetKey(KeyCode.Space) == true && cold_down == false)
        {

            rb.AddForce(0, 3, 0);


            ativa_contador = true;
            salto = true;
        }
        if (salto == true && contador_salto >= 1.5)
        {
            cold_down = false;
            contador_salto = 0;
            salto = false;
            ativa_contador = false;
        }

        //gravidade do salto
        if (salto == true && contador_salto >= 0.5)
        {
            cold_down = true;
            rb.AddForce(0, -3, 0);
        }

        //contador do salto
        if (ativa_contador == true)
        {
            contador_salto = contador_salto + 1 * Time.deltaTime;
        }

        //-------------------------------------------


        if (Input.GetKey(KeyCode.L) == true)
        {

            pp.transform.Rotate(0, 0, 10);


        }
    }
}