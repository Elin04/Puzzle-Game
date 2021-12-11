using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation45 : higlightgameobject , Iinteractabole
{
    public override void spin()
    {
        gameObject.transform.Rotate(0, 0, +45);
        

    }

}
