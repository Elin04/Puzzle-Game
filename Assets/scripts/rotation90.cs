﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation90 : higlightgameobject, Iinteractabole
{
    public override void spin()
    {
        gameObject.transform.Rotate(0, 0, +90);
    }





}
