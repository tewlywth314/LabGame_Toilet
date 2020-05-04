using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;
    public float MaxHp;
    public float damage;
    public float CurrentHp;
    

    public bool TakeDamage(float dmg)
    {
        CurrentHp -= dmg;
        if(CurrentHp <= 0)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }
}
