using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogStorage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SoilderDialog;
    void Start()
    {
        StartCoroutine(Dialog());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(5);
        SoilderDialog.SetActive(true);
    }
}
