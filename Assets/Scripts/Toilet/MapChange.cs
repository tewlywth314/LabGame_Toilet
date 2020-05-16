using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.Equals(player))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadSceneAsync("StorageBattle");
            }
        }
    }
}
