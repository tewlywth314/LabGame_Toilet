using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public static string ThisScene;
    void Start()
    {
        ThisScene = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync("deathscene");
        }
    }
}
