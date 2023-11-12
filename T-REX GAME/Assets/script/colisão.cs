using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisão : MonoBehaviour
{
    private controlo_pp colisão_vida;

    private void Start()
    {
        colisão_vida = GameObject.Find("player").GetComponent<controlo_pp>();
       
    }


    public void OnCollisionStay(Collision collision)
    {
        colisão_vida.gameObject.SetActive(false);
        print("morreu!!!");
    }
}
