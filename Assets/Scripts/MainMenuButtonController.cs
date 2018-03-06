using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonController : MonoBehaviour
{

    public GameObject startPageUI;
    public GameObject optionPageUI;
    public GameObject activeCanvasUI;
    // Use this for initialization

    public void showStartPage()
    {
        startPageUI.SetActive(true);
        optionPageUI.SetActive(false);
        activeCanvasUI.SetActive(false);
    }

    public void showOptionPage()
    {
        startPageUI.SetActive(false);
        optionPageUI.SetActive(true);
        activeCanvasUI.SetActive(false);
    }
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
        startPageUI.SetActive(false);
        optionPageUI.SetActive(false);
        activeCanvasUI.SetActive(true);
    }
    public void quitGame()
    {
        Application.Quit();
    }



}