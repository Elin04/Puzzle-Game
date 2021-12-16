using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Elin
public class gamecontoler : MonoBehaviour
{//scens en vilken spelet börjar på och slutar på
    public static int levelcompleat = 1;
    public int scensindex = 5;
    // en timmer för våran score system och en text för att desplaya den
    public static float timmer;
    public Text timmerText;
   
// så timemern stanar när den har staat  
      static bool timmeron = true;
    // en nextlevel function som vi kallar på när man träffar målet med ljuset
    public void newxtlevel()
    {// kollar så att det inte är sista nars går vi bara till sästa scen
        if (levelcompleat <scensindex)
        {
            
           
            SceneManager.LoadScene(levelcompleat);
            bool timmeron = true;
        }
        else 
        {// på sista scenen så säter vi timmern till false och hoppar till endscen scenen
            timmeron = false;
           
            SceneManager.LoadScene(5);

           
        }
        
    }

    public void Update()
    {// topar timern ifall timmeron är false 
      if(timmeron == true)
        {
            timmer += Time.deltaTime;

        }

        timmerText.text = "time: " + timmer;
       


    }
    public void savetime()
    {// sparar en float i timescore i playerprefs
        PlayerPrefs.SetFloat("timescore", timmer);

    }
    public void quitgame()
    {
        // en quit game knap funktion

        Application.Quit();

    }

    public void start()
    {
        // går till meny knap 
        //lodar första scenen
        SceneManager.LoadScene(0);

    }
}
