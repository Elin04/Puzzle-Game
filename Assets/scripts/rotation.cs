﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitinfo))
            {
                if (hitinfo.collider.gameObject.GetComponent<higlightgameobject>() != null)
                {
                    print("hitgameobject");
                    hitinfo.collider.transform.Rotate(0, 0, +45);

                    //gameObject.transform.rotation.eulerAngles.Set (0, 0, +90);
                }
            }
        }
    }
}
