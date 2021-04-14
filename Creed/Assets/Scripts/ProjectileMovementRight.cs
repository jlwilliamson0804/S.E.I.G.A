/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is unused at the moment, but can be used for 
 * ranged projectile attacks
 * Date: April 2021
 */
using UnityEngine;
using System.Collections;

public class ProjectileMovementRight: MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float bulletForce;

    //Movement
    void Start()
    {
            rb2d = GetComponent<Rigidbody2D>();
            rb2d.AddForce(transform.right * bulletForce);                   
        WaitAndDestroy();
    }
    void WaitAndDestroy()
    {
        var destroyTime = 2;
        Destroy(gameObject, destroyTime);
    }
}