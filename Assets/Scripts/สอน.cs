using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class สอน : MonoBehaviour
{
    public GameObject imageteaching;
    void Start()
    {
        imageteaching.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            imageteaching.SetActive(false);
        }
    }
}
