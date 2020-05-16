using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject Content;
    [SerializeField] Button Button;
    private void Update()
    {
        Button.transform.SetParent(Content.transform,true);
    }
}
