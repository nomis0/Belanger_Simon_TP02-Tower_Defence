using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : Tours, ITours
{


    // Constructeur
    public Bombe(GameObject platteforme)
    {
        degats = 5;
        cout = 10;
        atkSpd = 5f;
        enRecharge = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tirer()
    {

    }
}
