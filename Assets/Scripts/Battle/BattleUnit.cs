using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;
    public float MaxHp;
    public float MaxPolarized;
    public float damage;
    public float CurrentHp;
    public float CurrentPolarized;
    public int[] PolarizedWepID;
    

    public bool TakeDamage(float dmg)
    {
        CurrentHp -= dmg;

        TakePolarized(WeaponDropdown.PolarizedDmg);
        if (CurrentHp <= 0 || CurrentPolarized <= 0)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }
    public void TakePolarized(float dmg)
    {
        foreach(int ID in PolarizedWepID)
        {
            if (WeaponDropdown.id == ID)
            {
                CurrentPolarized -= dmg;
            }
            else
            {
                CurrentPolarized += 0;
            }
        }
        

    }
}
