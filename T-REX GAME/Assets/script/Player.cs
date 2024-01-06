using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject pp;
    public Rigidbody rb;

    public bool nochau;
   

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && gerador.start == true )
        {

            if (nochau == true)
            {
             rb.AddForce(0, 20, 0, ForceMode.Impulse);
            }
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("caiste");
            rb.AddForce(0, -1, 0, ForceMode.Force);
        }

        if (nochau == false)
        {
            print("caiste");
            rb.AddForce(0, -1, 0, ForceMode.Force);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            print("tocou");
            nochau = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            print("saiu");
            nochau = false;
        }
    }


}
