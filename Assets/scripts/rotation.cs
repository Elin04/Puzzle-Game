using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Oscar raycast för rotaring av mirrors
public class rotation : MonoBehaviour
{// tar in camran så man kan se vart musen är någon stans
    public Camera camera;
   
    void Update()
    {// tryker ner mouse button 0 
        if (Input.GetMouseButtonDown(0))
        {// skickar ut en raycast fårn pointen av musen (rackt fram)
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitinfo))
            {//kollar ifall vi har en gamobject som vi träfar med interfacen Iinteactabole och sedanan använder dens funciton ifall den har

                Iinteractabole interactive = hitinfo.collider.GetComponent<Iinteractabole>();
                if(interactive != null)
                {
                    interactive.spin();
                }

               
            
            }
        }
    }
}
