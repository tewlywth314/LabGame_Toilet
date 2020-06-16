using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Transform target;
    public Vector3 error;

    void Start()
    {
        error = new Vector3(0.6f, -2.3f, 0);
        target = GameObject.FindGameObjectWithTag("Heart").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 0.1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position-error, speed * Time.deltaTime);
        }
        if(BattleSystem.EnemFin == true)
        {
            Destroy(this.gameObject);
        }

    }
}
