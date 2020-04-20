using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator AnimLeft;
    [SerializeField] Animator AnimRight;
    [SerializeField] Animator AnimJump;

    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    [SerializeField] KeyCode MoveUp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveUp))
        {
            AnimJump.SetBool("ButtonShow", true);
        }
        else
        {
            AnimJump.SetBool("ButtonShow", false);
        }
        if (Input.GetKey(MoveRight))
        {
            AnimRight.SetBool("ButtonShow", true);
        }
        else
        {
            AnimRight.SetBool("ButtonShow", false);
        }
        if (Input.GetKey(MoveLeft))
        {
            AnimLeft.SetBool("ButtonShow", true);
        }
        else
        {
            AnimLeft.SetBool("ButtonShow", false);
        }
    }
}
