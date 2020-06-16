using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * Speed,0) ;
        if (DestroyBullet.Destroy == true)
        {
            Destroy(this.gameObject);
        }
        
    }
}
