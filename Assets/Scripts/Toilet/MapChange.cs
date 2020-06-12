using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    public GameObject player;
    public GameObject Mapchanger;
    public string Scenename;
    private int havechangemap;
    // Start is called before the first frame update
    void Start()
    {
        havechangemap = PlayerPrefs.GetInt("Change");
        if(havechangemap == 0)
        {
            player.transform.position = Mapchanger.transform.position;
            PlayerPrefs.SetInt("Change", 1);
        }
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
                SceneManager.LoadSceneAsync(Scenename);
                PlayerPrefs.SetInt("Change",0);
            }
        }
    }
}
