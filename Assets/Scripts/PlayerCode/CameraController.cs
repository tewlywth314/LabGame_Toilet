using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float xPos;
    public float x1 ;
    public float x2;






    void Start()
    { 
        
    }

   
    void Update()
    {
        if(player.transform.position.x < x1)
        {
            xPos = x1;
        }
        else if(player.transform.position.x >x2)
        {
            xPos = x2;
        }
        else
        {
            xPos = player.transform.position.x;
        }
        transform.position = new Vector3(xPos,transform.position.y,transform.position.z) ;

    }
}
