using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float FallMultiplier = 2.5f;
    [SerializeField] float LowJumpMultiplier = 2f;
    [SerializeField] KeyCode MoveUp;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up *Physics.gravity.y * (FallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y < 0 && Input.GetKeyDown(MoveUp))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (LowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
