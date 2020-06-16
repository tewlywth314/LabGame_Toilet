using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestRoomMap : MonoBehaviour
{
    public GameObject RestBattle;
    public GameObject Kitchen;
    public GameObject punch;
    public GameObject Millitarry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DefeatedCheck.Defeated == 1)
        {
            RestBattle.SetActive(false);
            Kitchen.SetActive(true);
            punch.SetActive(false);
        }
        if (DefeatedCheck.Defeated == 2)
        {
            Millitarry.SetActive(true);
        }
    }
}
