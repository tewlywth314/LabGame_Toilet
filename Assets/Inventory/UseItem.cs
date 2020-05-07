using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UseItem : MonoBehaviour
{
    string Name;
    public void Click()
    {
        Name = gameObject.name;
        Debug.Log(Name);
        
    }
}
