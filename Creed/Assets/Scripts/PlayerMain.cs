/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script is for the main player, attributes and functionality during the level
 * Date: April 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth = 100;
    private GameMaster gm;
    public Health healthbar;
    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth; // sets health of player
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        healthbar.SetInit(MaxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHealth > 0)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<PlayerMovement>().enabled = true;
            
        }
        
    }

    //function to allow player to take damage
    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        healthbar.SetAmount(CurrentHealth);

        if (CurrentHealth <= 0)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            SFX.PlayDeath();
            GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<Animator>().Play("Player_Death");
            animator.SetBool("IsDead", true);
            animator.SetBool("isRunning", false);
            StartCoroutine(Death());
            
        }

    }

    //public void Death()
    IEnumerator Death()
    {
        

        // timer delay
        yield return new WaitForSeconds(2);
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

    //if player completes a level, sends to next level/home page
    void OnTriggerEnter2D(Collider2D trigg)
    {
        //if object collides with another that has the tag for ending the levels
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
