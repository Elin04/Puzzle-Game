using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootlight : MonoBehaviour
{
    public Material material;
    light lightbeam;
    

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("light beam"));
        lightbeam = new light(gameObject.transform.position, gameObject.transform.forward, material);
    }
}
