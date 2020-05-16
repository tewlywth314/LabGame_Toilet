using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Text;

public class WeaponDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Dropdown Weapons;
    ItemLoader player;
    public List<string> WeaponName;
    string jsonPath;



    // Update is called once per frame
    private void Start()
    {
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
        File.ReadAllText(jsonPath);
        player = FindObjectOfType<ItemLoader>();
       
       foreach(Item item in player.playerItems)
        {
            string name = item.ItemName;
            WeaponName.Add(name);

        }
        WeaponList();
    }

    public void WeaponList()
    {
        Weapons.AddOptions(WeaponName);
    }
    private void Update()
    {
        
    }

}
