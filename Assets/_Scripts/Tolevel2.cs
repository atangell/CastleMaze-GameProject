using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tolevel2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("Level 2");
    }
}