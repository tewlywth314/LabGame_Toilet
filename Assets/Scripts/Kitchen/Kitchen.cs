using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kitchen : MonoBehaviour
{
    public GameObject KitchenBattle;
    public GameObject punch;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (DefeatedCheck.Defeated == 2)
        {
            KitchenBattle.SetActive(false);
            punch.SetActive(false);

        }
    }
}
