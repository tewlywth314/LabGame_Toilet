using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody rb;
    private Vector3 PlayerPos;
  
   
    private Vector3 CameraVelo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = Player.transform.position;
        CameraVelo = Player.GetComponent<Rigidbody>().velocity;
       


        if (Player.transform.position.x > transform.position.x && CameraVelo.x > 0)
        {
            rb.AddForce(CameraVelo * 45.5f , ForceMode.Acceleration);
        
        }

        if (Player.transform.position.x < transform.position.x && CameraVelo.x < 0)
        {

            rb.AddForce(CameraVelo * 45.5f , ForceMode.Acceleration);
            

        }
        rb.velocity = Vector3.zero;








    }
}
