using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surgeon2 : MonoBehaviour
{
    public GameObject Doctar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DefeatedCheck.Defeated == 5)
        {
            Doctar.SetActive(false);

        }
    }
}
