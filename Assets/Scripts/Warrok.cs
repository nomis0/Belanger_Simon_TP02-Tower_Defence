using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : Ennemie
{
    //Constructeur
    public Warrok(int nbVague)
    {
        Gold = 3;
        vitesse = 1;
        pv = 3 + nbVague/2;
    }

    public override void Deplacer()
    {
        base.Deplacer();
    }

    public override void Touché(Ennemie ennemie)
    {
        base.Touché(ennemie);

        //Se divise quand il meurt
        
    }
}
