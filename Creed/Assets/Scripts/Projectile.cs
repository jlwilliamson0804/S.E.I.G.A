/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is for the ranged attack
 *  and if it hits specific tags
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D rb;
    public int damageAmount = 30;
    

    // Start is called before the first frame update
    void Start()
    {
        
        //fires the projectile in the correct direction at the defined speed
        rb.velocity = transform.right * speed; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    //collision detection for the fireball
    void OnTriggerEnter2D (Collider2D hit)
    {
      EnemyMain enemy = hit.GetComponent<EnemyMain>();
      if(hit.tag == "wall" && hit != null)
        {

            SFX.PlayFireball();
            Destroy(gameObject); //so it doesn't pass through walls
            
        }


      if(enemy.gameObject.tag == "enemy" || enemy.gameObject.tag == "boss")
        {
            SFX.PlayFireball();
            enemy.LoseHealth(damageAmount); // damages the enemy
            Destroy(gameObject);
        }
      
    }
}
