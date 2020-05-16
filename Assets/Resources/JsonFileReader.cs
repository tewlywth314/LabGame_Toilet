using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonFileReader 
{
    // Start is called before the first frame update
    public static string LoadJsonAsResource(string path)
    {
        string jsonFilePath = path.Replace(".json", "");
        TextAsset loadedJsonfile = Resources.Load<TextAsset>(jsonFilePath);
        return loadedJsonfile.text;
    }
}
