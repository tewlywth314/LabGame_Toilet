using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exusial : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("End", false);
        StartCoroutine(Barrage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Barrage()
    {
        yield return new WaitForSeconds(10f);
        anim.SetBool("End", true);
    }
}
