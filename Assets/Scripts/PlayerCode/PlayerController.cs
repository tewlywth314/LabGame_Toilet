using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float jumpVelocity;
    [SerializeField] Animator anim;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    [SerializeField] KeyCode MoveUp;
    float rotate = 180;
    [SerializeField] bool Jumped;
    public GameObject Grounded;
    [SerializeField] bool CanMove;


    // BetterJump
    [SerializeField] float FallMultiplier = 2.5f;
    [SerializeField] float LowJumpMultiplier = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement1();
        
    }
    void Movement1()
    {
        if(CanMove == true)
        {
            Move();
            Jump();
            anim.SetBool("IsStopping", false);
        }
        else
        {
            anim.SetBool("IsStopping", true);
        }
       
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(Grounded))
        {
            Jumped = false;
            anim.SetBool("IsJumping", false);
        }
       
    }
    void Jump()
    {
        
        if (Input.GetKey(MoveUp) && Jumped == false)
        {

            rb.velocity = Vector3.up * jumpVelocity;
            
            Jumped = true;
            
        }
        if (Jumped == true)
        {
            anim.SetBool("IsJumping", true);
        }
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (FallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y < 0 && Input.GetKeyDown(MoveUp))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (LowJumpMultiplier - 1) * Time.deltaTime;
        }

    }
    void Move()
    {

       
        if(Mathf.Abs(rb.velocity.x) >= 2 && Jumped == false)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        if (Input.GetKey(MoveRight))
        {
            //rb.velocity = new Vector3(speed * Time.deltaTime, 0f, 0f);
            rb.AddForce( speed * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
            if (rotate != 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0f;
            }

        }
        
        if (Input.GetKey(MoveLeft))
        {
            //rb.velocity = new Vector3(-1 * speed * Time.deltaTime, 0f, 0f);
            rb.AddForce(-1 * speed * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
            if (rotate != 180)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;
            }
        }
        
    }

}
