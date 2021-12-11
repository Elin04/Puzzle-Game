using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamecontoler : MonoBehaviour
{
    public static int levelcompleat = 1;
    public int scensindex = 4;

    public static float timmer;
    public Text timmerText;
   
  
    static bool timmeron = true;

    public void newxtlevel()
    {
        if (levelcompleat <scensindex)
        {
            
           
            SceneManager.LoadScene(levelcompleat);
            bool timmeron = true;
        }
        else 
        {
            timmeron = false;
           
            SceneManager.LoadScene(4);

           
        }
        
    }

    public void Update()
    {
      if(timmeron == true)
        {
            timmer += Time.deltaTime;

        }

        timmerText.text = "time: " + timmer;
       


    }/*
    public void savescore()
    {
        PlayerPrefs.GetFloat("timescore");

    }*/
    public void savetime()
    {
        PlayerPrefs.SetFloat("timescore", timmer);

    }
    public void quitgame()
    {


        Application.Quit();

    }

    public void start()
    {

        SceneManager.LoadScene(0);

    }
}
