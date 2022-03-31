using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glace : Tours, ITours
{
    

    // Constructeur
    public Glace(GameObject platteforme)
    {
        degats = 1;
        cout = 4;
        atkSpd = 2.5f;
        enRecharge = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tirer(IEnnemies ennemie, Transform transf_ennemie)
    {
        // Tire avec balistique
    }
}
