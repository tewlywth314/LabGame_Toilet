using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatedCheck : MonoBehaviour
{
    private int i;
    public static int Defeated = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i <= 0 && BattleSystem.State == BattleState.WON)
        {
            i++;
            Defeated++;
            Debug.Log(Defeated);
        }
    }
}
