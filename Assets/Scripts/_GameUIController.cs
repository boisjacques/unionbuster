using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GameUIController : MonoBehaviour {

    public UnityEngine.UI.Text playerName;
    public UnityEngine.UI.Text actionText;

	// Use this for initialization
	void Start () 
    {
        playerName.text = PlayerPrefs.GetString("username");
	}

    public void updateActionText(string s)
    {
        actionText.text = s;
    }
  
	// Update is called once per frame
	void Update () 
    {
	 
    }
}
