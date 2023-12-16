using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    public GameObject player;

    public float tempo;
    public bool start;
    


    void Update()
    {
        if (start == true)
        {
            player.transform.Translate((1+tempo)*Time.deltaTime, 0, 0);
        }

        if (start == true)
        {
            tempo = tempo + 3 * Time.deltaTime;
        }


    }



    public void começo()
    {
        start = true;
    }
}
