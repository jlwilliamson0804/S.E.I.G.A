/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is used in conjuction with another to save checkpoints
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    private static SavePos instance;
    public Vector2 position;

    // creates first instance of object, if already exist then destroy it
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }



}
