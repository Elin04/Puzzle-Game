﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitinfo))
            {

                Iinteractabole interactive = hitinfo.collider.GetComponent<Iinteractabole>();
                if(interactive != null)
                {
                    interactive.spin();
                }

               
            
            }
        }
    }
}
