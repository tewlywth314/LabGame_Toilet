using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorageCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StorageCutsceneStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StorageCutsceneStart()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadSceneAsync("bully scene");
    }
}
