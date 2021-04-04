using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public int Health;
    public int Attack;
    public int CurHealth;

    public Animator anim;

    public void LoseHealth(int amount)
    {
        Health -= amount;

        if(Health <=0)
        {
            Death();
        }

    }

    public void Death()
    {
        //call death animation here
        // anim.SetBool("AmDead", true);

        //disables the enemy the object
        Destroy(gameObject);
    }

    void Start()
    {
        CurHealth = Health;

        if(gameObject.tag == "enemy")
        {
            Health = 100;
            Attack = 20;
        }

        else if(gameObject.tag == "boss")
        {
            Health = 200;
            Attack = 25;
        }
    }

    

}
