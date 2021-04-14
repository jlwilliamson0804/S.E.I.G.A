using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFX : MonoBehaviour
{
    public static AudioClip Fireball;
    public static AudioClip SwordAttack;
    public static AudioClip Death;
    static AudioSource src;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Fireball = Resources.Load<AudioClip>("explosion");
        SwordAttack = Resources.Load<AudioClip>("sword");
        Death = Resources.Load<AudioClip>("death");
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlayDeath()
    {
        src.PlayOneShot(Death);
    }

    public static void PlaySword()
    {
        src.PlayOneShot(SwordAttack);
    }

    public static void PlayFireball()
    {
        src.PlayOneShot(Fireball);

    }
}