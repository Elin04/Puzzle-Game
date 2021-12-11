using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class higlightgameobject : MonoBehaviour, Iinteractabole
{
    public Renderer rendr;
    
    void Start()
    {
       
        rendr = GetComponent<Renderer>();
      
    }


    private void OnMouseEnter()
    {
        rendr.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rendr.material.color = Color.white;
    }

    public virtual void spin()
    {
        
    }
}
