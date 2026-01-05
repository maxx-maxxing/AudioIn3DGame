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
        masterSlider.value = PlayerPrefs.GetFloat("Master", 0f);
        sfxSlider.value    = PlayerPrefs.GetFloat("SFX", 0f);
        musicSlider.value  = PlayerPrefs.GetFloat("Music", 0f);
    }


    public void UpdateMasterVolume()
    {
        mixer.SetFloat("Master", masterSlider.value);
        PlayerPrefs.SetFloat("Master", masterSlider.value);
        PlayerPrefs.Save();
    }

    
    public void UpdateSfxVolume()
    {
        mixer.SetFloat("SFX", sfxSlider.value);
        PlayerPrefs.SetFloat("SFX", sfxSlider.value);
    }



    public void UpdateMusicVolume()
    {
        mixer.SetFloat("Music", musicSlider.value);
        PlayerPrefs.SetFloat("Music", musicSlider.value);
    }
    
    void Start ()
    {
        // do we have saved volume player prefs?
        if(PlayerPrefs.HasKey("Master"))
        {
            // set the mixer volume levels based on the saved player prefs
            mixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
            mixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFX"));
            mixer.SetFloat("Music", PlayerPrefs.GetFloat("Music"));

            SetSliders();
        }
        // otherwise just set the sliders
        else
        {
            SetSliders();
            mixer.SetFloat("Master", masterSlider.value);
            mixer.SetFloat("SFX", sfxSlider.value);
            mixer.SetFloat("Music", musicSlider.value);
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            window.SetActive(!window.activeInHierarchy);
        }

        if (window.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
