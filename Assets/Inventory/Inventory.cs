using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject itemtext;
    bool set = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            if (set == false)
            {
                set = true;
                canvas.SetActive(set);
            }
            else
            {
                set = false;
                canvas.SetActive(set);
            }
        }
    }
}
