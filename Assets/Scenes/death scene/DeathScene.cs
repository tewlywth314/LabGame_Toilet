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
            SceneManager.LoadScene(BeforeScene);
        }
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
=======
       
>>>>>>> master
    }
}