using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armory : MonoBehaviour
{
    public GameObject Quest;
    public GameObject NurseRoom;
    public GameObject AssemblyHall;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (QuestAccpeted.Accepted == true)
        {
            Quest.SetActive(false);
            NurseRoom.SetActive(true);
            
        }
        if (DefeatedCheck.Defeated == 5)
        {
            AssemblyHall.SetActive(true);
        }
    }
}
