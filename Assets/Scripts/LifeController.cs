using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
 
    public static int lebenValue = 3;
    Text life;


    // Use this for initialization
    void Start()
    {
        life = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        life.text = lebenValue.ToString();
    }
}
