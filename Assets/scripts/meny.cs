using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class meny : MonoBehaviour
{
    public int buildIndex;
    public Text timmerText;
    public float scoree;

    // Start is called before the first frame update


    // Update is called once per frame


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
    {

        scoree = PlayerPrefs.GetFloat("timescore");
        timmerText.text = (""+ scoree);

    }
}
