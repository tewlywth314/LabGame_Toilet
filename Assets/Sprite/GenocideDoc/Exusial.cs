using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Exusial : MonoBehaviour
{
    private Animator anim;
    private AudioSource Audio;
    public AudioClip Deployed;
    public AudioClip ApplePie;
    public AudioClip skill3;

    // Start is called before the first frame update
    void Start()
    {
        
        Audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        anim.SetBool("End", false);
        Audio.PlayOneShot(Deployed);
        StartCoroutine(Barrage());
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Barrage()
    {
        yield return new WaitForSeconds(1f);
        Audio.PlayOneShot(ApplePie);
        yield return new WaitForSeconds(1.2f);
        Audio.PlayOneShot(skill3,1f);
        yield return new WaitForSeconds(6f);
        
        anim.SetBool("End", true);
    }
}
