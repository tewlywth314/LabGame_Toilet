using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexasBlade : MonoBehaviour
{
    public GameObject blade;
    public Transform startpos;
    // Start is called before the first frame update
    void Start()
    {
        DestroyBullet.Destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBlade()
    {
        
        Instantiate(blade, startpos);

    }
}
