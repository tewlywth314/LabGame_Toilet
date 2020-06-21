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
    public GameObject item;
    public List<string> WeaponName;
    string jsonPath;
    public float multi = 1;
    public static int id;
    public static float PolarizedDmg;
    public static bool DropdownOn;



    // Update is called once per frame
    private void Start()
    {
        WeaponName =  new List<string> { "Select your weapon" };
        jsonPath = Application.persistentDataPath + "/ItemDictionary.json";
        File.ReadAllText(jsonPath);
        player = item.GetComponent<ItemLoader>();
        
       
       foreach(Item itemZ in player.playerItems)
        {
            string name = itemZ.ItemName;
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
        if(Weapons == null)
        {
            DropdownOn = false;
        }
        else
        {
            DropdownOn = true;
        }
    }
    public void DropDownWeaponChanged(int index)
    {
        if(Weapons!= null)
        {
            foreach (Item itemZ in player.playerItems)
            {
                if (WeaponName[index] == itemZ.ItemName)
                {
                    multi = itemZ.MultiplierDamage;
                    id = itemZ.ID;
                    Debug.Log(id);
                    PolarizedDmg = itemZ.PolarizedDamage;
                }

            }
        }
       
    }

}
