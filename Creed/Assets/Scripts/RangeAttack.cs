using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject FireBallPreFab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //click to shoot
        if(Input.GetButtonDown("Fire1"))
        {
            Fire();
        }



    }

    //fire method
   void Fire()
    {
        //logic for shooting a projectile
        Instantiate(FireBallPreFab, ShootPoint.position, ShootPoint.rotation);

    }
}
