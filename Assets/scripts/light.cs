using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    Vector3 pos, dir;
    GameObject lightObject;
    LineRenderer lightt;
    List<Vector3> lightindect = new List<Vector3>();


    // olika refractials matrials 
    Dictionary<string, float> refractivematerials = new Dictionary<string, float>()
    {
        {"Air",1.0f},
        {"Glass",1.5f}
    };

    public light(Vector3 pos, Vector3 dir,Material material)
    {
        this.lightt = new LineRenderer();
        this.lightObject = new GameObject();
        this.lightObject.name = "light beam";
        this.pos = pos;
        this.dir = dir;

        this.lightt = this.lightObject.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.lightt.startWidth = 0.1f;
        this.lightt.endWidth = 0.1f;
        this.lightt.material = material;
        this.lightt.startColor = Color.magenta;
        this.lightt.endColor = Color.magenta;

        castray(pos, dir, lightt);
    }
  

    void castray(Vector3 pos, Vector3 dir, LineRenderer light)
    {
        lightindect.Add(pos);
        //kanshe ska göra om till 2d
        Ray ray = new Ray(pos, dir);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 30, 1))
        {
            checkhit(hit,dir,lightt);
        }
        else
        {
            lightindect.Add(ray.GetPoint(30));
            updatelight();
        }
    }

    void updatelight()
    {
        int count = 0;
        lightt.positionCount = lightindect.Count;
        foreach (Vector3 idx in lightindect)
        {
            lightt.SetPosition(count, idx);
            count++;
        }
    }

    void checkhit(RaycastHit hitinfo, Vector3 direction, LineRenderer llight)
    {
        if(hitinfo.collider.gameObject.tag == "mirror")
        {
            Vector3 pos = hitinfo.point;
            Vector3 dir = Vector3.Reflect(direction, hitinfo.normal);

            castray(pos, dir, llight);
        }
        else if (hitinfo.collider.gameObject.tag == "Refract")
        {//light träfar glaset som då använder vi pointen och normal vectorn för att kuna räkan ut refractal punkten när den går in och där i och sedan vinken när den går utt
            Vector3 pos = hitinfo.point;
            lightindect.Add(pos);

            //minimerar chansen för erors
            Vector3 newpos1 = new Vector3(Mathf.Abs(direction.x) / (direction.x + 0.0001f) * 0.001f + pos.x, Mathf.Abs(direction.y) / (direction.y + 0.0001f) * 0.001f + pos.y, Mathf.Abs(direction.z) / (direction.z + 0.0001f) * 0.001f + pos.z);

            // refractal nummer
            float n1 = refractivematerials["Air"];
            float n2 = refractivematerials["Glass"];

            // vat den träfar och normal värdet av vart den träfar
            Vector3 norm = hitinfo.normal;
            Vector3 incident = direction;
            
            // skapar en ny light beam i den med den korekta refractial punkten
            Vector3 refractedvector = Refractt(n1, n2, norm, incident);
           

            //skapar en ny raycast en bit bakom så den kan upptäka gamobjectet igen så vi kan räkna ut den utgående refracten
            Ray ray1 = new Ray(newpos1, refractedvector);
            Vector3 newraystartpos = ray1.GetPoint(1.5f);

            Ray ray2 = new Ray(newraystartpos, -refractedvector);
            RaycastHit hit2;

            if(Physics.Raycast(ray2, out hit2, 1.6f, 1))
            {
                lightindect.Add(hit2.point);
            }

            updatelight();

            Vector3 refractedvector2 = Refractt(n2, n1, -hit2.normal, refractedvector);
            castray(hit2.point, refractedvector2, lightt);
        }
        else
        {
            lightindect.Add(hitinfo.point);
            updatelight();
        }
    }


    Vector3 Refractt(float n1, float n2, Vector3 norm, Vector3 incident)
    {

        incident.Normalize();
        // mate för att räkna utt refractal pointsen
        Vector3 refractedvector = (n1 / n2 * Vector3.Cross(norm, Vector3.Cross(-norm, incident)) - norm * Mathf.Sqrt(1 - Vector3.Dot(Vector3.Cross(norm, incident) * (n1 / n2 * n1 / n2), Vector3.Cross(norm, incident)))).normalized;
        // skikar tillbacka refractuak punktenrna
        return refractedvector;
    }
  
}
