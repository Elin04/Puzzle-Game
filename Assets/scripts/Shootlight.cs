using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Oscar
public class Shootlight : MonoBehaviour
{// läger till en ett matirila för line renderen ska använda och sedan tar fårn light scripet
    public Material material;
    light lightbeam;
    

    void Update()
    {// destoryar bemen varje frame så den det inte skapas för många
        Destroy(GameObject.Find("light beam"));
        // skapar en lihgt bem som går ut åt framot fårn gameobjextet som jag spawnar den ifårn och då skickar in materialen till light beam scriptet
        lightbeam = new light(gameObject.transform.position, gameObject.transform.forward, material);
    }
}
