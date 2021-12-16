using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation90 : higlightgameobject, Iinteractabole
{// Oscar 
    // inheritar hilightgamobject som jag sedan overidar dens spin och 
    //lägar till interactabole som jag chekar när jag ska snura på mirrorsana
    public override void spin()
    {// rotatar game objext med 90 grader
        gameObject.transform.Rotate(0, 0, +90);
    }





}
