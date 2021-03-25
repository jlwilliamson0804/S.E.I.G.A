using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D rb;

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
}
