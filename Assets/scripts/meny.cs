﻿using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meny : MonoBehaviour
{
    public int buildIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Laddar in eller avslutar spelet när du trycker på represive knappar.
    public void quitgame()
    {


        Application.Quit();

    }

    public void start()
    {

        SceneManager.LoadScene(buildIndex);

    }
}
