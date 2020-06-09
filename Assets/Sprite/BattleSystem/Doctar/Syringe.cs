using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Syringe : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Rigidbody rb;
    public float y;
    public float multiSpeed = 1;
    public float multiHigh = 1;
    public float TimeSet;
    // Start is called before the first frame update
    void Start()
    {
        SpawnSyringe.Destroy = false;
        TimeSet = Time.time;
        
        sprite = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody>();
        StartCoroutine(wave());
       
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnSyringe.Destroy == true)
        {
            Destroy(this.gameObject);
        }
        Vector3 position = new Vector3(transform.position.x - multiSpeed*0.06f, y+multiHigh*Mathf.Sin(Time.time-TimeSet), transform.position.z);
        rb.MovePosition(position);

    }
    IEnumerator wave()
    {
        sprite.color = new Color(1, 1, 1, 0);
        yield return new WaitForSeconds(0.2f);
        sprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        sprite.color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(12f);
        sprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.5f);
        sprite.color = new Color(1, 1, 1, 0);


    }
}
