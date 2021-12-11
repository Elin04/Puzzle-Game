using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation90 : MonoBehaviour, Iinteractabole
{
    private Renderer rendr;

    void Start()
    {

        rendr = GetComponent<Renderer>();

    }


    private void OnMouseEnter()
    {
        rendr.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        rendr.material.color = Color.white;
    }

    public void spin()
    {
        gameObject.transform.Rotate(0, 0, +90);
    }
}
