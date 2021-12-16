using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Elin
public class meny : MonoBehaviour
{// scenen man ska byta till och texten och floten för score
    public int buildIndex;
    public Text timmerText;
    public float scoree;

  


    // Laddar in eller avslutar spelet när du trycker på represive knappar.
    public void quitgame()
    {


        Application.Quit();

    }

    public void start()
    {
        
        SceneManager.LoadScene(buildIndex);

    }

    public void loadscore()
    {// lodar scoren i som jag savede i gamecontoler och sedan displayar den

        scoree = PlayerPrefs.GetFloat("timescore");
        timmerText.text = (""+ scoree);

    }
}
