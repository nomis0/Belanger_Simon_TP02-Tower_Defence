using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class Skeleton : Ennemie
{
    public AudioSource sourceSkeleton;
    public AudioClip clipMortSkeleton;

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

    public override void Touché(Ennemie ennemie)
    {
        base.Touché(ennemie);

        if (pv <= 0)
        {
            Meurs(ennemie);
        }
    }

    void Meurs(Ennemie ennemie)
    {
        ennemie.enabled = false;
        sourceSkeleton.PlayOneShot(clipMortSkeleton);
        // le dire à main
    }
}
