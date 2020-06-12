using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class PolarizedDic : MonoBehaviour
{
    string jsonPath;
    // Start is called before the first frame update
    void Start()
    {
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
        ItemDictionary it = JsonUtility.FromJson<ItemDictionary>(File.ReadAllText(jsonPath));
        it.Items.Add("Items/Weapons/Mop.json");
        string json = JsonUtility.ToJson(it);
        Debug.Log(json);

        File.WriteAllText(jsonPath, json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        
    }
}
