using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour
{
    // Varialbles des ennemies
    protected int Gold { get { return Gold; } set { value = Gold; } }
    protected int vitesse { get { return vitesse; } set { value = vitesse; } }
    protected int pv { get { return pv; } set { value = pv; } }

    public virtual void Deplacer()
    {

    }

    public virtual void Touché(Ennemie ennemie)
    {
        pv -= 1; 
    }
}
