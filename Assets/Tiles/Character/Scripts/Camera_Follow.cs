using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    private Transform playerBoy;

    void Start()
    {
        playerBoy = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playerBoy.position.x;
        temp.y = playerBoy.position.y;

        transform.position = temp;
    }
}
