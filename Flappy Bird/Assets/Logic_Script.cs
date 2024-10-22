using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
 
    [ContextMenu("Increase Score")] //Adds an option to test a function without always needed to run the game
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString(); //The Text UI in Unity is of String data type, so type conversion is necessary
    }
 
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//This reloads the scene
    }
 
    public void gameOver()
    {
        //SetActive(boolean x) This method can hide/unhide a game object currently present in the Scene
        gameOverScreen.SetActive(true);
    }
}