using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMain : MonoBehaviour
{
    public int Health;
    private GameMaster gm;
    

    // Start is called before the first frame update
    void Start()
    {
        Health = 100; // sets health of player
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to allow player to take damage
    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Death();
        }

    }

    public void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //if collides with enemy take damage
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "enemy")
        {
            TakeDamage(20);
        }
        else if (col.gameObject.tag == "boss")
        {
            TakeDamage(25);
        }
    }

    void OnTriggerEnter2D(Collider2D trigg)
    {
        //if object collides with another that has the tag "turn_around"
        if (trigg.gameObject.CompareTag("EndLevel1"))
        {
            SceneManager.LoadScene("Title_Scene");
        }

        if (trigg.gameObject.CompareTag("EndTutorial"))
        {
            SceneManager.LoadScene("Level1");
        }
    }
    }
