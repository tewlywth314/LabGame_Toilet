using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR : MonoBehaviour
{
    float X, Y, Z;
    void Start()
    {
        X = PlayerPrefs.GetFloat("x");
        Y = PlayerPrefs.GetFloat("y");
        Z = PlayerPrefs.GetFloat("z");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("Ch", 1);
            PlayerPrefs.SetFloat("x", X);
            PlayerPrefs.SetFloat("y", Y);
            PlayerPrefs.SetFloat("z", Z);
            SceneManager.LoadSceneAsync(PlayerPrefs.GetString("CS"));
            
        }
    }
}
