using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;


public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    //public TMP_Dropdown resolutionDropdown;

    //Resolution[] resolutions;
    void Start()
    {
        //resolutions = Screen.resolutions;

        //resolutionDropdown.ClearOptions();

        //List<string> listoptions = new List<string>();

        //int allcurrentresolution = 0;
        //for (int i = 0; i < resolutions.Length; i++)
        //{
        //    string option = resolutions[i].width + " x " + resolutions[i].height;
        //    listoptions.Add(option);

        //    if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
        //    {
        //        allcurrentresolution = i;
        //    }
        //}
        //resolutionDropdown.AddOptions(listoptions);
        //resolutionDropdown.value = allcurrentresolution;
        //resolutionDropdown.RefreshShownValue();
    }

    //public void SetResolution(int allresolution)
    //{
    //    Resolution resolution = resolutions[allresolution];
    //    Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    //}
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);   
    }
    
    public void SetFullccreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
