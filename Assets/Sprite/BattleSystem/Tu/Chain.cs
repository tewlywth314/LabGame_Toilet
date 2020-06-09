using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public float MaxX;
    public float MaxY;
    public float MinY;
    public float MinX;
    public float randX = 0;
    public float randY = 0;
    Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;
        StartCoroutine(RandPos());
    }

    // Update is called once per frame
    void Update()
    {
        randX = Random.Range(MinX, MaxX);
        randY = Random.Range(MinY, MaxY);
    }
    IEnumerator RandPos()
    {
        for(int i = 0;i< 7; i++)
        {
            yield return new WaitForSeconds(2.5f);

            transform.position = new Vector3(Pos.x + randX, Pos.y + randY, Pos.z);
        }
        
    }
}
