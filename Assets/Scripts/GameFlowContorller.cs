using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFlowContorller : MonoBehaviour

{


    public _GameUIController uiController;
    public SoundController sounds;
    public MusicController music;
    public GameObject lvlUpText;
    public GameObject bulletcontroller;
    public Animator player;
    public Text levelText;

    public GameObject Player;
    public GameObject PlayerBullet;
    public GameObject Monster1;
    public GameObject Monster1Bullet;

    public GameObject Monster2;
    public GameObject Monster2Bullet;

    public GameObject Monster3;
    public GameObject Monster3Bullet;

    public GameObject Life;

    #region SpawningPoints

    public GameObject begin1;
    public GameObject begin2;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject spawnPoint5;
    public GameObject spawnPoint6;
    public GameObject spawnPoint7;
    public GameObject spawnPoint8;
    public GameObject spawnPoint9;
    public GameObject spawnPoint10;

    #endregion

    public int lvl = 0;





    // Use this for initialization
    private void Awake()
    {
        
    }


    void Start()
    {

        #region Spawning Points set false
        spawnPoint1.SetActive(false);
        spawnPoint2.SetActive(false);
        spawnPoint3.SetActive(false);
        spawnPoint4.SetActive(false);
        spawnPoint5.SetActive(false);
        spawnPoint6.SetActive(false);
        spawnPoint7.SetActive(false);
        spawnPoint8.SetActive(false);
        spawnPoint9.SetActive(false);
        spawnPoint10.SetActive(false);

#endregion

        StartCoroutine(startNewRound());

    }



    public IEnumerator startNewRound()
    {
        yield return StartCoroutine(startAnimationCoroutine());
        //Irgendwas
    }

    private IEnumerator startAnimationCoroutine()
    {
        uiController.updateActionText("3");
        sounds.click.Play();
        player.GetComponent<Animator>().SetBool("startAnim", true);
        yield return new WaitForSeconds(1);

        sounds.click.Play();
        uiController.updateActionText("2");
        yield return new WaitForSeconds(1);

        sounds.click.Play();
        uiController.updateActionText("1");
        yield return new WaitForSeconds(1);

        sounds.click.Play();
        uiController.updateActionText("GO!");
        yield return new WaitForSeconds(1);
        uiController.updateActionText("");

        begin1.SetActive(true);
        begin2.SetActive(true);
        music.music.Play();
        player.GetComponent<Animator>().SetBool("startAnim", false);
        bulletcontroller.SetActive(true);


        yield break;
    }



    // Update is called once per frame
    public IEnumerator levelUP()
    {
        yield return StartCoroutine(checkLevel());
    }

    private IEnumerator checkLevel()

    {
      
        if  (ScoreController.scoreValue >99 &&  lvl<1)
        {
            lvl++;
            levelText.text = "1";
            sounds.lvlup.Play();
            uiController.updateActionText("LVL UP!");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("Level 1");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("");


            spawnPoint1.SetActive(true);
            spawnPoint2.SetActive(true);

            yield break;
        }

        if (ScoreController.scoreValue > 250 && lvl < 2)
        {
            lvl++;
            levelText.text = "2";
            sounds.lvlup.Play();
            uiController.updateActionText("LVL UP!");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("Level 2");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("");


            spawnPoint3.SetActive(true);
            spawnPoint4.SetActive(true);
            yield break;
        }

        if (ScoreController.scoreValue > 499 && lvl < 3)
        {
            lvl++;
            sounds.lvlup.Play();
            uiController.updateActionText("LVL UP!");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("Level 3");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("");
            levelText.text = "3";

            spawnPoint5.SetActive(true);
            spawnPoint6.SetActive(true);
            yield break;
        }

        if (ScoreController.scoreValue > 699 && lvl < 4)
        {
            lvl++;
            sounds.lvlup.Play();
            uiController.updateActionText("LVL UP!");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("Level 4");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("");
            levelText.text = "4";

            spawnPoint7.SetActive(true);
            spawnPoint8.SetActive(true);
            yield break;
        }

        if (ScoreController.scoreValue > 799 && lvl < 5)
        {
            lvl++;
            sounds.lvlup.Play();
            uiController.updateActionText("LVL UP!");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("Maxlevel");
            yield return new WaitForSeconds(1);
            uiController.updateActionText("");
            levelText.text = "Maximun";

            spawnPoint9.SetActive(true);
            spawnPoint10.SetActive(true);
            yield break;
        }
    }
    public IEnumerator checkLife()
    {
        yield return StartCoroutine(checkLifeNow());
    }
    public IEnumerator checkLifeNow()
    {
        if (LifeController.lebenValue <= 0)
        {
            SceneManager.LoadScene("GameOver");
            LifeController.lebenValue = 3;
            yield break;
        }
    }

    //Sound Abspielen


    // Update is called once per frame

     void Update()
    {
        StartCoroutine(levelUP());
        StartCoroutine(checkLife());

    }
}


