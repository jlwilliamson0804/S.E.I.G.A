﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    public Animator anim;
    public Transform Sword;
    public float Range = 0.5f;
    public LayerMask enemies;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Backspace))
        {
            Melee();
        }
    }

    void Melee()
    {
        //trigger attack animation
        anim.SetTrigger("Attack");

        //detect range
        Collider2D[] EnemiesDamaged =  Physics2D.OverlapCircleAll(Sword.position, Range, enemies);

        //do damage
        foreach(Collider2D Enemies in EnemiesDamaged)
        {
            Enemies.GetComponent<EnemyMain>().LoseHealth(20);
        }
        
    }
}