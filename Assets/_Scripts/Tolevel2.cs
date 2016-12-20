using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tolevel2 : MonoBehaviour
{

    public static int finalScore;
    void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene("Level 2");
        scoreManager.Score = PlayerShooting.finalScore;
        scoreManager.Score += PlayerShooting.scoreValue;
        finalScore = scoreManager.Score;
    }
}