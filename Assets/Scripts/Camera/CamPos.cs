using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody rb;
    private Vector3 PlayerPos;
  
   
    private Vector3 CameraVelo;
    private Vector3 PlayerVelo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = Player.transform.position;
        CameraVelo = gameObject.GetComponent<Rigidbody>().velocity;
        PlayerVelo = Player.GetComponent<Rigidbody>().velocity;


        if (Player.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            gameObject.GetComponent<Rigidbody>().velocity = PlayerVelo;
            //Debug.Log("Bet");
        }

        else if (Player.transform.position.x > transform.position.x && PlayerVelo.x > 0)
        {
            rb.AddForce(new Vector3(1, 0, 0) * 80.5f, ForceMode.Acceleration);

            //Debug.Log("Bet2");
        }

        else if (Player.transform.position.x < transform.position.x && PlayerVelo.x < 0)
        {

            rb.AddForce(new Vector3(-1, 0, 0) * 80.5f, ForceMode.Acceleration);
            //Debug.Log("Bet3");
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }











    }
}
