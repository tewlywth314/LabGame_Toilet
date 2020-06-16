using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float y = transform.position.y;
        StartCoroutine(Spin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spin()
    {
        yield return new WaitForSeconds(2.5f);
        transform.Translate(2f, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, 45f);
        yield return new WaitForSeconds(2.5f);
        transform.Translate(2f, -1.9f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 90f);
        yield return new WaitForSeconds(2.5f);
        transform.Translate(2f, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, 135f);
        yield return new WaitForSeconds(2.5f);
        transform.Translate(-2f, -1.9f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 180f);
    }
}
