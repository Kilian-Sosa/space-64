using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        int savedSong = PlayerPrefs.GetInt("BackgroundMusicSelected", 0);
        float savedVolume = PlayerPrefs.GetFloat("BackgroundMusicVolume", 0.72f);
        AudioManager.instance.PlayMusic(savedSong.ToString());
        AudioManager.instance.ChangeVolume(savedVolume);
    }
    public void GoToSettings()
    {
        SceneController.instance.LoadScene("GeneralSettingsScene");
    }
}
