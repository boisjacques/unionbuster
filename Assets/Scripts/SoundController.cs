using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

    public AudioSource bulletEnemySound;
    public AudioSource laserSound;
    public AudioSource bulletPlayerSound;
    public AudioSource buttonSound;
    public AudioSource gameoverSound;
    public AudioSource alarm;
    public AudioSource lvlup;
    public AudioSource click;

    public UnityEngine.UI.Toggle soundMuteToggle;
    public UnityEngine.UI.Slider soundSlider;
    public UnityEngine.UI.Text soundText;


    private void Awake()
    {
        if(PlayerPrefs.HasKey("isSoundMuted"))
        {
            if(PlayerPrefs.GetString("isSoundMuted") == "true")
            {
                if (soundMuteToggle != null)
                {
                    soundMuteToggle.isOn = false;
                }
            }
        }

        if(PlayerPrefs.HasKey("soundVolume"))
        {
            bulletEnemySound.volume = PlayerPrefs.GetFloat("bulletEnemySoundVolume") / 100f;
            laserSound.volume = PlayerPrefs.GetFloat("laserSoundVolume") / 100f;
            bulletPlayerSound.volume = PlayerPrefs.GetFloat("bulletPlayerSoundVolume") / 100f;
            gameoverSound.volume = PlayerPrefs.GetFloat("gameoverSoundVolume") / 100f;
            alarm.volume = PlayerPrefs.GetFloat("alarmVolume") / 100f;
            lvlup.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
            click.volume = PlayerPrefs.GetFloat("lvlupVolume") / 100f;
        }

        if (soundSlider != null)

        {
            soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
        }
        if(soundText !=null)
        {
            soundText.text = PlayerPrefs.GetFloat("soundVolume").ToString();
        }
    }
    public void changeVolume(float f)
    {
        PlayerPrefs.SetFloat("soundVolume", f);
        bulletEnemySound.volume = f / 100f;
        laserSound.volume = f / 100f;
        bulletPlayerSound.volume = f / 100f;
        buttonSound.volume = f / 100f;
        alarm.volume = f / 100f;
        lvlup.volume = f / 100f;
        gameoverSound.volume = f / 100f;
        click.volume = f / 100f;
        soundText.text = f.ToString();
    }
    public void toggleMute()
    {
        if (soundMuteToggle.isOn)
        {
            bulletEnemySound.mute = false;
            laserSound.mute = false;
            bulletPlayerSound.mute = false;
            buttonSound.mute = false;
            alarm.mute = false;
            lvlup.mute= false;
            gameoverSound.mute = false;
            click.mute = false;

            PlayerPrefs.SetString("isSoundMuted", "false");

        }
        else
        {
            bulletEnemySound.mute = true;
            laserSound.mute = true;
            bulletPlayerSound.mute = true;
            buttonSound.mute = true;
            alarm.mute = true;
            lvlup.mute = true;
            gameoverSound.mute = true;
            click.mute = true;
            PlayerPrefs.SetString("isSoundMuted", "true");
        }
    }
    private void Update()
    {

        if (soundMuteToggle.isOn)
        {
            bulletEnemySound.mute = false;
            laserSound.mute = false;
            bulletPlayerSound.mute = false;
            buttonSound.mute = false;
            alarm.mute = false;
            lvlup.mute = false;
            gameoverSound.mute = false;
            click.mute = false;
            PlayerPrefs.SetString("isSoundMuted", "false");

        }
        else
        {
            bulletEnemySound.mute = true;
            laserSound.mute = true;
            bulletPlayerSound.mute = true;
            buttonSound.mute = true;
            alarm.mute = true;
            lvlup.mute = true;
            gameoverSound.mute = true;
            click.mute = true;
            PlayerPrefs.SetString("isSoundMuted", "true");
        }
    }

}
