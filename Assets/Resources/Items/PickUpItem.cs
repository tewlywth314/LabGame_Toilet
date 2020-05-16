using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class PickUpItem : MonoBehaviour
{
    public GameObject ThisItem;
    public GameObject player;
    string jsonPath;

    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ItemDictionary it = JsonUtility.FromJson<ItemDictionary>(File.ReadAllText(jsonPath));
            it.Items.Add(ThisItem.GetComponent<ItemPath>().Path);
            string json = JsonUtility.ToJson(it);
            Debug.Log(json);
           
            File.WriteAllText(jsonPath, json);
            
        }

    }
    private void Update()
    {

        
    }
    private void Start()
    {
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
    }

}
