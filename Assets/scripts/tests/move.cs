using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour, Iinteractabole
{
    private Renderer rendr;
    public GameObject[] movepoints;
    bool startpoint = true;

    public GameObject moveinggamohject;
    public GameObject movepositon;
    private Vector3 postion1;
    private Vector3 postion2;

    // Start is called before the first frame update
    void Start()
    {
        postion1 = movepositon.transform.position;
        postion2 = moveinggamohject.transform.position;
        rendr = GetComponent<Renderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        rendr.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rendr.material.color = Color.white;
    }
    public void spin()
    {/*
       
        if(startpoint = true)
        {
            moveinggamohject.transform.position = postion2;
            startpoint = false;
        }
        else
        {
            moveinggamohject.transform.position = postion1;
            startpoint = true;
        }*/
    }
}
