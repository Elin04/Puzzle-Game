using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Oscar
public class higlightgameobject : MonoBehaviour, Iinteractabole
{// tar en renderer 
    public Renderer rendr;
    
    void Start()
    {
       // tar gameobjectes renderer som scriptet liger på
        rendr = GetComponent<Renderer>();
      
    }


    private void OnMouseEnter()
    {// ifall musen går över gameobjext så byter den färg till röd
        rendr.material.color = Color.red;
    }

    private void OnMouseExit()
    {// ifal den går bort fårn gamobjectet så byter den till backa till white som är base colorn 
        rendr.material.color = Color.white;
    }
    // definar spin functionen
    public virtual void spin()
    {
        
    }
}
