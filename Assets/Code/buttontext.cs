using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class buttontext : MonoBehaviour
{
    public Text bodytext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        bodytext.gameObject.SetActive(!bodytext.gameObject.activeSelf);
    }

    void Clicked()
    {
       // Debug.Log("Hello");
    }
}
