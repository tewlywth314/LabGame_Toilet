using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject Bomb;
    public static bool Destroy;
    private GameObject D;
    private Vector3 Pos;
    public int n;
    private float randX;
    private float randY;
    // Start is called before the first frame update
    void Start()
    {
        randX = Random.Range(1, 4);
        randY = Random.Range(-4, -1);
        Destroy = false;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        randX = Random.Range(0, 5);
        randY = Random.Range(-5, 0);
    }
    IEnumerator Spawn()
    {
        randX = Random.Range(0, 5);
        randY = Random.Range(-5, 0);
        for (int i = 1; i < n; i++)
        {
           
            Pos = new Vector3(Bomb.transform.position.x+randX, Bomb.transform.position.y+randY, Bomb.transform.position.z);
            yield return new WaitForSeconds(0.5f);
            D = Instantiate(Bomb, Pos, Quaternion.identity);
        }


    }
    public void DestroyClone()
    {
        Destroy = true;
    }
}
