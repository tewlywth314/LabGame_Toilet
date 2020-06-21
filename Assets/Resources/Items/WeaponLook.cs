using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLook : MonoBehaviour
{
    private SpriteRenderer Rend;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Rend = GetComponent<SpriteRenderer>();
        Rend.sprite = GetComponent<ItemSprite>().WeaponSprite[WeaponDropdown.id];
        Debug.Log(GetComponent<ItemSprite>().WeaponSprite.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (WeaponDropdown.DropdownOn)
        {
            Rend.sprite = GetComponent<ItemSprite>().WeaponSprite[WeaponDropdown.id];
        }
        
    }
}
