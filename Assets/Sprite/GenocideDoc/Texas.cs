using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texas : MonoBehaviour
{
    public GameObject bladeSpawn;
    private Animator anim;
    private Animator Ownanim;
    private AudioSource Audio;
    public AudioClip Deployed;
    public AudioClip Skill;
    // Start is called before the first frame update
    void Start()
    {
        Ownanim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
        Ownanim.SetBool("End", false);
       
        anim = bladeSpawn.GetComponent<Animator>();
        anim.SetBool("Spawn", false);
        Audio.PlayOneShot(Deployed);
        StartCoroutine(startSkill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator startSkill()
    {
        yield return new WaitForSeconds(2f);
        anim.SetBool("Spawn", true);
        Audio.PlayOneShot(Skill);
        yield return new WaitForSeconds(10f);
        anim.SetBool("Spawn", false);
        Ownanim.SetBool("End", true);
    }
}
