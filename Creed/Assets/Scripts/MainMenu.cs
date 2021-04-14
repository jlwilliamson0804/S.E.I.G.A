/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script manages our scenes 
 *      and loads the next scene in the build 
 * Date: February 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   static public int multiplier=1;

    public void PlayGame() // function for our play button
    {
        SceneManager.LoadScene("Level1"); // Loads the next scene in the build order
    }
    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial"); // Loads the tutorial
    }

    public void QuitGame() // function for quit button
    {
        Application.Quit();
    }

    //the following are multipliers for difficulty system
    public void EasyGame()
    {
        multiplier = 1;
    }

    public void MediumGame()
    {
        multiplier = 2;
    }

    public void HardGame()
    {
        multiplier = 3;
    }

}



