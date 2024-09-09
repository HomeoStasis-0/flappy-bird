using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;

   public GameObject gameOverScreen;
   public AudioSource ding;

    [ContextMenu("Score Increase")]
   public void addScore(int scoreToAdd) {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
    ding.Play();
   }
   public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

    public void GameOver() {
        gameOverScreen.SetActive(true);
    }
}
