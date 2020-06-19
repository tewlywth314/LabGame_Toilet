using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    public string BeforeScene;
    public void Start()
    {
        BeforeScene = test.ThisScene;
    }   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            heart.isDead = false;
            SceneManager.LoadScene(BeforeScene);
            Debug.Log(heart.isDead);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }

    }
}