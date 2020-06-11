using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    public GameObject player;
    public string NextScene;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.Equals(player))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
<<<<<<< Updated upstream
                SceneManager.LoadSceneAsync("StorageRoom");
=======
                SceneManager.LoadSceneAsync(NextScene);
>>>>>>> Stashed changes
            }
        }
    }
}
