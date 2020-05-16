using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class ItemLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Item> playerItems;
    string jsonPath;
    void Awake()
    {
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
        playerItems = new List<Item>();
        ItemDictionary dictionary = JsonUtility.FromJson<ItemDictionary>(File.ReadAllText(jsonPath));
        foreach (string dictionaryitem in dictionary.Items)
        {
            //Debug.Log(dictionaryitem);
            LoadItem(dictionaryitem);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadItem(string path)
    {
        string loadPlayerItem = JsonFileReader.LoadJsonAsResource(path);
        //Debug.Log(loadPlayerItem);
        Item item = JsonUtility.FromJson<Item>(loadPlayerItem);
        playerItems.Add(item);
    }
   
}
