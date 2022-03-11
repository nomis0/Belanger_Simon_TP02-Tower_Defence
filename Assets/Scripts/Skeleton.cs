using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Ennemie
{
    //Constructeur
    public Skeleton(int nbVague)
    {
        Gold = 1;
        vitesse = 2;
        pv = 1 + nbVague / 2;
    }

    public override void Deplacer()
    {
        base.Deplacer();
    }

    public override void Touché()
    {
        base.Touché();
    }
}
