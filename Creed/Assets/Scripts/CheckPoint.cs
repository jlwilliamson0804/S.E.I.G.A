/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is used in conjuction with another to save checkpoints
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameMaster gm;

    //gets the object we are looking for
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    //if player collides with object it will make this object have it's last position
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }



}
