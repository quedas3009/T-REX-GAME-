using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIRD : MonoBehaviour
{
    public GameObject bird;
    public float timer;
    
    void Update()
    {
        if (gerador.start == true)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        bird.transform.Translate(-8 *Time.deltaTime , 0, 0);

    }
}
