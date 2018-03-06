using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPage : MonoBehaviour {

    public UnityEngine.UI.Text usernameText;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("username"))
        {
            usernameText.text = PlayerPrefs.GetString("username");
        }
    }

    public void changeusername(string s)
    {
        usernameText.text = s;
        PlayerPrefs.SetString("username", s);
    }

}
