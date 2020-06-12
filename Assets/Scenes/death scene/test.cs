using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public static string ThisScene;
    public string winscene;
    private int i = 1;
    void Start()
    {
        ThisScene = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if(i == 1 && BattleSystem.State == BattleState.LOST)
        {
            i++;
            StartCoroutine(BeforeDeath());
        }
        if (i == 1 && BattleSystem.State == BattleState.WON)
        {
            i++;
            StartCoroutine(BeforeWin());
        }
    }
    IEnumerator BeforeDeath()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync("deathscene");
    }
    IEnumerator BeforeWin()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync(winscene);
    }
}
