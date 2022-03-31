using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourTir : Tours, ITours
{
    

    // Constructeur
    public TourTir(GameObject platteforme)
    {
        degats = 2;
        cout = 1;
        atkSpd = 1f;
        enRecharge = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void Tirer()
    {

    }
}
