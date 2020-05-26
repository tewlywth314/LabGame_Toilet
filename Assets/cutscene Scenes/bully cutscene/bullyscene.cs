using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bullyscene : MonoBehaviour

{
    int loop = 0;
    public bool tew = false;
    VideoPlayer video;
    public GameObject nexttext;
    public void Start()
    {
        video = GameObject.Find("SB1").GetComponent<VideoPlayer>();
        nexttext.SetActive(false);
        StartCoroutine(one());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tew = true;
        }

        if (tew == true)
        {
            video.Play();
            nexttext.SetActive(false);
            StartCoroutine(two());
            tew = false;
            loop++;

            if (loop == 4)
            {
                SceneManager.LoadSceneAsync("Storageroom");
            }
        }
    }
    IEnumerator one()
    {
        yield return new WaitForSeconds(4f);
        video.Pause();

        nexttext.SetActive(true);
    }
    IEnumerator two()
    {
        yield return new WaitForSeconds(5f);
        video.Pause();

        nexttext.SetActive(true);
    }
}
