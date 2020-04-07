using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Animator anim;
    float rotate = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3( speed * Time.deltaTime,0f,0f);
            anim.SetBool("IsWalking", true);
            if (rotate != 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0f;
            }
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-1*speed * Time.deltaTime, 0f, 0f);
            anim.SetBool("IsWalking", true);
            if (rotate != 180)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;
            }
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

    }
        
    
}
