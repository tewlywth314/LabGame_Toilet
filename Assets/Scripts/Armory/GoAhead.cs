using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAhead : MonoBehaviour
{
    public GameObject Go;
    public static bool MoveAhead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveAhead == true)
        {
            Go.SetActive(true);

        }
        if (MoveAhead == false)
        {
            Go.SetActive(false);

        }
    }
}
