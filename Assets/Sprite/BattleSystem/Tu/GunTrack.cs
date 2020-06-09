using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTrack : MonoBehaviour
{
   
    private Transform heart ;
    public float speed;
    public Vector3 error;
    public GameObject bullet;
    public Transform startpos;
    float Speed2;
    bool Canshoot = true;


    // Start is called before the first frame update
    void Start()
    {
        error = new Vector3(0.41f, 0.5f, 0);
        DestroyBullet.Destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Transform>();
        Speed2 = speed;
        if (Canshoot)
        {
            var q = Quaternion.LookRotation(heart.position - error - transform.position);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, Speed2 * Time.deltaTime);

        }
        else
        {
            var q = Quaternion.LookRotation(heart.position - error - transform.position);
            Speed2 = 0;

            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, Speed2 * Time.deltaTime);
        }
        


    }
    public void SpawnBullet()
    {
        StartCoroutine(ShootWait());
        Instantiate(bullet, startpos);
       
    }
    IEnumerator ShootWait()
    {
        Canshoot = false;
        yield return new WaitForSeconds(0.5f);
        Canshoot = true;
        

    }
    
}
