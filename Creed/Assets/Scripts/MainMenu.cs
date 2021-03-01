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
    public void PlayGame() // function for our play button
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads the next scene in the build order
    }

    public void QuitGame() // function for quit button
    {
        Application.Quit();
    }


}
