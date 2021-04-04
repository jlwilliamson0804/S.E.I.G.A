using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public int Health;
    

    // Start is called before the first frame update
    void Start()
    {
        Health = 100; // sets health of player
        


    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to allow player to take damage
    public void TakeDamage(int amount)
    {
        Health -= amount;


    }


    //if collides with enemy take damage
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "enemy")
        {
            TakeDamage(20);
        }
        else TakeDamage(25);
    }

}
