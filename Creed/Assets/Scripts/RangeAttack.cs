/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is being used to bring an instance of our fireball into the game
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject FireBallPreFab;
    
    public float cooldownTime=2;
    private float fireTime=0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > fireTime)
        {
            //click to shoot
            if (Input.GetButtonDown("Fire1"))
            {

                Fire();
                fireTime = Time.time + cooldownTime;
            }

        }

    }

    //fire method
   void Fire()
    {

        
            //logic for shooting a projectile
            Instantiate(FireBallPreFab, ShootPoint.position, ShootPoint.rotation);
            
    }
}
