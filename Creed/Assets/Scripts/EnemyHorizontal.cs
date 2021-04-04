using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyHorizontal : MonoBehaviour
{

    //Moevement speed (0 means dont move)
    public float speed=0;

    //Switch movement direction every x seconds
    public float switchTime = 2;

    //moving to the right?
    public bool GoingRight;

    // Use this for initialization
    void Update()
    {
        

        //if moving to the right, pace, and right facing images
        if(GoingRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else //going left, pace, and left facing images
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }


    }

    //if an object is a trigger then will execute this function
    void OnTriggerEnter2D(Collider2D trigg)
    {
        //if object collides with another that has the tag "turn_around"
        if(trigg.gameObject.CompareTag("turn_around"))
        {
            if (GoingRight)
            {
                GoingRight = false; // now go left
            }
            else GoingRight = true; // now go right
        }
    }

    //blocks the player from pushing the enemy, enemy can push player
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Rigidbody2D rg = GetComponent<Rigidbody2D>();
            rg.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }


    void Switch()
    {

        GetComponent<Rigidbody2D>().velocity *= -1;

    }
}
