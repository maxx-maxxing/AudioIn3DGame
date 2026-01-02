using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeUI : MonoBehaviour
{
    public AudioMixer mixer;

    public GameObject window;
    public Slider masterSlider;
    public Slider sfxSlider;
    public Slider musicSlider;

    void SetSliders()
    {
        masterSlider.value = PlayerPrefs.GetFloat("Master");
        sfxSlider.value = PlayerPrefs.GetFloat("SFX");
        musicSlider.value = PlayerPrefs.GetFloat("Music");
        
    }

    public void UpdateMasterVolume()
    {
        mixer.SetFloat("Master", masterSlider.value);
        PlayerPrefs.SetFloat("Master", masterSlider.value);
    }
    
    public void UpdateSFXVolume()
    {
        mixer.SetFloat("SFX", masterSlider.value);
        PlayerPrefs.SetFloat("SFX", masterSlider.value);
    }

    public void UpdateMusicVolume()
    {
        mixer.SetFloat("Music", musicSlider.value);
        PlayerPrefs.SetFloat("Music", musicSlider.value);
    }
    
    void Start ()
    {
        // do we have saved volume player prefs?
        if(PlayerPrefs.HasKey("MasterVolume"))
        {
            // set the mixer volume levels based on the saved player prefs
            mixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            mixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));

            SetSliders();
        }
        // otherwise just set the sliders
        else
        {
            SetSliders();
        }
    }
}
