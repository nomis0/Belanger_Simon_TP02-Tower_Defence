using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightshade : Ennemie
{
    //Constructeur
    public Nightshade(int nbVague)
    {
        Gold = 2;
        vitesse = 3;
        pv = 2 + nbVague / 2;
    }

    public override void Deplacer()
    {
        // Passe autravers des obstacles

    }

    public override void Touché()
    {
        base.Touché();
    }
}
