using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation45 : higlightgameobject , Iinteractabole
{// Oscar 
    // inheritar hilightgamobject som jag sedan overidar dens spin och 
    //lägar till interactabole som jag chekar när jag ska snura på mirrorsana
    public override void spin()
    {// rotatar gameobjectet med 45 grader
        gameObject.transform.Rotate(0, 0, +45);
        

    }

}
