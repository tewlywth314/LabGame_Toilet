using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float xPos;


    


    void Start()
    { 
        
    }

   
    void Update()
    {
        if(player.transform.position.x < -12)
        {
            xPos = -12f;
        }
        else if(player.transform.position.x > 10)
        {
            xPos = 10f;
        }
        else
        {
            xPos = player.transform.position.x;
        }
        transform.position = new Vector3(xPos,transform.position.y,transform.position.z) ;

    }
}
