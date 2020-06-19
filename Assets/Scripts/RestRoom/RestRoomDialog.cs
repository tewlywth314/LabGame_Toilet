using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestRoomDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI dialog;
    public string[] DialogArray;
    private int j = 0;
    
    void Start()
    {
        StartCoroutine(DialogRun());
    }
    private void Update()
    {
        dialog.text = "" + DialogArray[j];
        
    }
    // Update is called once per frame
    IEnumerator DialogRun()
    {
        for (int i=0;i < DialogArray.Length;)
        {
            yield return new WaitForSeconds(5.0f);
            i++;
            if (i >= DialogArray.Length)
            {
                i = 0;
            }
            j = i;
        }
        
       
    }
}
