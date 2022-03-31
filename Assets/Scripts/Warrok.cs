using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : Ennemie, IEnnemies
{
    //Constructeur
    public Warrok(int nbVague)
    {
        Gold = 3;
        vitesse = 1;
        pv = 3 + nbVague/2;
    }

    public void Deplacer()
    {
        
    }

    public void Touché()
    {
        

        //Se divise quand il meurt
        
    }
}
