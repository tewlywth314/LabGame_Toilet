using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestAccpeted : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool Accepted = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GoAhead.MoveAhead = false;

            }
        }
    }

}
