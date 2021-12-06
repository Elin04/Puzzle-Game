using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class higlightgameobject : MonoBehaviour
{
    private Renderer rendr;
    // Start is called before the first frame update
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
}
