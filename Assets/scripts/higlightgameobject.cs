using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class higlightgameobject : MonoBehaviour, Iinteractabole
{
    private Renderer rendr;
    
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
  
    public void spin()
    {
        gameObject.transform.Rotate(0, 0, +45);
    }
}
