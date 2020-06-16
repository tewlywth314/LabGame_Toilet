using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    [SerializeField] GameObject virus;
    void Start()
    {
        StartCoroutine(ShootVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ShootVirus()
    {
        yield return new WaitForSeconds(1.2f);
        Instantiate(virus, transform.position, transform.rotation);
        yield return new WaitForSeconds(1.2f);
        Instantiate(virus, transform.position, transform.rotation);
        yield return new WaitForSeconds(1.2f);
        Instantiate(virus, transform.position, transform.rotation);


    }
}
