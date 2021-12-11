using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamecontoler : MonoBehaviour
{
    public int levelcompleat = 1;
    public int scensindex = 5;

    public float timmer = 0;
    public Text timmerText;

    public void newxtlevel()
    {
        if (levelcompleat <scensindex-1)
        {

            SceneManager.LoadScene(levelcompleat);

        }
        else if(levelcompleat <= scensindex)
        {
            SceneManager.LoadScene(scensindex);
        }
        
    }

    public void Update()
    {
        timmer += Time.deltaTime;
        timmerText.text = "time: " + timmer;
    }/*
    public void savescore()
    {
        PlayerPrefs.GetFloat("timescore");

    }*/

    private void Start()
    {
        if(levelcompleat >= scensindex)
        {
            //loda higscore

        }

    }
}
