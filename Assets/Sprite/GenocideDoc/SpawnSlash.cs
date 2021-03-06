﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpawnSlash : MonoBehaviour
{
    private Transform heart = null;
    public GameObject Slash;
    private Vector3 error;
    private Vector3 Pos;
    public AudioClip ChenDeployed;
    public AudioClip ChenSlash;
    public AudioClip Chen3;
    private AudioSource Audio;
    

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.PlayOneShot(ChenDeployed);
        error = new Vector3(0.6f, -2.3f, 0);
        StartCoroutine(ChenSkill3());
    }

    // Update is called once per frame
    void Update()
    {

        heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Transform>();
    }
    public void SpawnSlashChen()
    {
        heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Transform>();
        Pos = heart.position -error ;
        float i = Random.Range(0, 360);
        GameObject D = Instantiate(Slash,Pos , Quaternion.Euler(0,0, i));
        Audio.PlayOneShot(ChenSlash,0.5f);
    }
    IEnumerator ChenSkill3()
    {
        
        yield return new WaitForSeconds(2f);
        Audio.PlayOneShot(Chen3);
        yield return new WaitForSeconds(2f);
        heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Transform>();
        for (int i = 1; i <= 11; i++)
        {
            yield return new WaitForSeconds(0.5f);
            SpawnSlashChen();
            SpawnSlashChen();
        }
        

    }
}
