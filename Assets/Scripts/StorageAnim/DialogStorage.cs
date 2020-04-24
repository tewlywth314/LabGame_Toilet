using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogStorage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SoilderDialog;
    public GameObject StorageManDialog;
    public GameObject PlayerDialog;
    public AudioSource Audio;
    public AudioClip Clip;
    public Animator Anim;
    public float volume = 1f;
    void Start()
    {
        Anim.SetBool("IsBattle", true);
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
        yield return new WaitForSeconds(1.5f);
        StorageManDialog.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Audio.PlayOneShot(Clip, volume);
        PlayerDialog.SetActive(true);
    }
}
