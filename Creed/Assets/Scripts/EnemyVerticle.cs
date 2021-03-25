using UnityEngine;
using System.Collections;

public class EnemyVerticle: MonoBehaviour
{

    //Moevement speed (0 means dont move)

    public float speed = 0;

    //Switch movement direction every x seconds
    public float switchTime = 2;

    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        //Switch every few seconds

        InvokeRepeating("Switch", 0, switchTime);

    }

    void Switch()
    {

        GetComponent<Rigidbody2D>().velocity *= -1;

    }
}
