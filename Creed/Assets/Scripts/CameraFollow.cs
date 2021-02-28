using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;


    
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //finds the object with tag "player" which is our main character
    }

    
    void LateUpdate()
    {
        //current camera position
        Vector3 temp = transform.position;

        //set camera x position to players x position
        temp.x = playerTransform.position.x;
        //set camera y position to players y position
        temp.y = playerTransform.position.y;

        //reset camera position to current position
        transform.position = temp;

        //

    }
}
