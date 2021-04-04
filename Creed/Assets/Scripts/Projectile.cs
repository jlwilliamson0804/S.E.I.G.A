using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D rb;
    public int damageAmount = 20;

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
      if(hit.tag == "wall")
        {
            Destroy(gameObject);
        }


      if(enemy.gameObject.tag == "enemy")
        {
            enemy.LoseHealth(damageAmount);
            Destroy(gameObject);
        }
      
    }
}
