using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    Vector3 pos, dir;
    GameObject lightObject;
    LineRenderer light;
    List<Vector3> lightindect = new List<Vector3>();

    public light(Vector3 pos, Vector3 dir,Material material)
    {
        this.light = new LineRenderer();
        this.lightObject = new GameObject;
        this.lightObject.name = "light beam";
        this.pos = pos;
        this.dir = dir;

        this.light = this.lightObject.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.light.startWidth = 0.1f;
        this.light.endWidth = 0.1f;
        this.light.material = material;
        this.light.startColor = Color.white;

    }
    void Start()
    {
     }

   
    void Update()
    {
        
    }


}
