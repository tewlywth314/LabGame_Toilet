using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChangeDoc : MonoBehaviour
{
    public static int Doc = 1;
    public GameObject player;
    public GameObject Mapchanger;
    public string Scenename;
    public string ScenenameGenocide;

    // Start is called before the first frame update
    void Start()
    {
        
        if (Doc == 0)
        {
            Debug.Log("Do");
            player.transform.position = Mapchanger.transform.position;
            Doc = 1;
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
                if(Genocide.GenocideCount > 0)
                {
                    SceneManager.LoadSceneAsync(ScenenameGenocide);
                    Doc = 0;
                }
                else
                {
                    SceneManager.LoadSceneAsync(Scenename);
                    Doc = 0;
                }
                
            }
        }
    }
}
