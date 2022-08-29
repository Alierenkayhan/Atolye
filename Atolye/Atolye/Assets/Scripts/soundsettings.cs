using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class soundsettings : MonoBehaviour
{
    public TMP_Text volumeAmount;

    public Slider slider;

    public Toggle toggle;
    private void Start()
    {
        LoadAudio();
      
    }
    
    public void SetAudio(float value)
    {
        AudioListener.volume = value; // setting all sounds in the unity and changes between 0 and 1
        volumeAmount.text = ((int)(value*100)).ToString();
        SaveAudio();
    }

    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);
    }

    private void LoadAudio()
    {
        try
        {
            if (PlayerPrefs.HasKey("audioVolume"))
            {
                AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
                slider.value = PlayerPrefs.GetFloat("audioVolume");
            }
            else
            {
                PlayerPrefs.SetFloat("audioVolume", 0.5f);
                AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
                slider.value = PlayerPrefs.GetFloat("audioVolume");
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }


    public void setFullscreen(bool fullscreen)
    {
        if (toggle.isOn) Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        else Screen.fullScreenMode = FullScreenMode.Windowed;
    }
}
