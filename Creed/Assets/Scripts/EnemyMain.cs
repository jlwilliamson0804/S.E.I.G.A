/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is used to give enemies functionality and attributes
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public int Health;
    public int Attack;
    public int CurHealth;
    //public MainMenu MM;
    //int mult;

    public Animator anim;

    
    //take damage function
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

    //sets beginning stats depending on type of enemy
    void Start()
    {
        CurHealth = Health;
        
        
        if(gameObject.tag == "enemy")
        {
            Health = 100*MainMenu.multiplier;
            Attack = 20;
            
        }

        else if(gameObject.tag == "boss")
        {
            Health = 200*MainMenu.multiplier;
            Attack = 25;
        }
    }

    

}
