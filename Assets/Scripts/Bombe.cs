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

    void OnTriggerEnter()
    {

    }

    public void Tirer(Ennemie ennemie)
    {
        // tire la bombe sur l'ennemie avec balistique

        Exploser();
    }

    void Exploser()
    {
        // Attenque secondes et explose
    }
}
