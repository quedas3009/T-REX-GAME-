using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    public GameObject player;
    public GameObject camera2;


    void Update()
    {
        Vector3 playerposição = player.transform.position;

        camera2.transform.position = new Vector3(playerposição.x +35, 10, -34);
    }
}
