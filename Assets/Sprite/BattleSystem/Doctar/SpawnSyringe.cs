using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSyringe : MonoBehaviour
{
    public GameObject syringe;
    private Vector3 Pos;
    private GameObject D;
    public static bool Destroy;
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        Destroy = false;
        StartCoroutine(Spawn());
        Pos = new Vector3(syringe.transform.position.x, syringe.transform.position.y, syringe.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        for(int i =1;i < n; i++)
        {
            yield return new WaitForSeconds(0.5f);
            D = Instantiate(syringe, Pos, Quaternion.identity);
        }
       

    }
    public void DestroyClone()
    {
        Destroy = true;
    }
}
