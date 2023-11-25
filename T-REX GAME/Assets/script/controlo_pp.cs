using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlo_pp : MonoBehaviour
{
    public GameObject pp;
    public Rigidbody rb;
    Vector3 salto;

    float pesomaximo = 1f;
    float hora_de;


    float velocidadesalto;
    float gravidade;

    bool nochão = false;



    private void Start()
    {
        gravidade = (2 * pesomaximo) / Mathf.Pow(hora_de,2);
        velocidadesalto = gravidade * hora_de;

    }


    void Update()
    {
        //------SALTAR-----------------------------

        salto += gravidade * Time.deltaTime * Vector3.down;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            salto = velocidadesalto * Vector3.up;
        }

        transform.position += (Vector3)salto * Time.deltaTime;
        //-------------------------------------------


        if (Input.GetKey(KeyCode.L) == true)
        {

            pp.transform.Rotate(0, 0, -1000 * Time.deltaTime);


        }






        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            pp.transform.Translate(9 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            pp.transform.Translate(-9  * Time.deltaTime, 0, 0);
        }


    }
}