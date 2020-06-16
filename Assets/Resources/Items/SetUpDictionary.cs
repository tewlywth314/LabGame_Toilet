using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SetUpDictionary : MonoBehaviour
{
    string jsonPath;
    
    // Start is called before the first frame update
    void Start()
    {
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
        Debug.Log(jsonPath);
        string StartDictionary = File.ReadAllText("Assets/Resources/Items/ItemDictionary.json");
        File.WriteAllText(jsonPath, StartDictionary);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
