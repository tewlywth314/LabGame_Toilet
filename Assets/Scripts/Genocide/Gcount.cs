using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gcount : MonoBehaviour
{
    private int i;
  
    public Slider EnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(i == 0 && EnemyHP.value <= 0)
        {
            i++;
            Genocide.GenocideCount++;
            Debug.Log(Genocide.GenocideCount);
        }
    }
}
