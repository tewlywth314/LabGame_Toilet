using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surgeon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Nurse;
    public GameObject Soilder;
    public GameObject Doctar;
    public GameObject nursebox;
    public static bool NurseEnable = true;
    public static bool DoctarEnable = false;

    private void Awake()
    {
        
        if (DefeatedCheck.Defeated == 3)
        {
            Nurse.SetActive(false);
         
            
        }
        if (DefeatedCheck.Defeated >= 4)
        {
            Soilder.SetActive(false);

        }
        if(DoctarEnable == true)
        {
            Doctar.SetActive(true);
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DefeatedCheck.Defeated == 3)
        {
            Soilder.SetActive(false);
            Nurse.SetActive(true);
        }
        if (DefeatedCheck.Defeated >= 4)
        {
            Soilder.SetActive(false);
            Nurse.SetActive(false);
            NurseEnable = false;
            
        }
        if(NurseEnable == false)
        {
            nursebox.SetActive(false);
            Doctar.SetActive(true);
            DoctarEnable = true;
        }
    }

}
