using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    public GameObject player;
    public GameObject camera2;


    void Update()
    {
        Vector3 playerposi��o = player.transform.position;

        camera2.transform.position = new Vector3(playerposi��o.x +35, 10, -34);
    }
}
