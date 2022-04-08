using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glace : Tours, ITours
{
    

    // Constructeur
    public Glace()
    {
        degats = 1;
        cout = 4;
        atkSpd = 2.5f;
        enRecharge = false;
    }

    void OnTriggerEnter()
    {

    }

    public void Tirer(Ennemie ennemie)
    {
        // Tire avec balistique


        enRecharge = true;
        StartCoroutine(Recharge());
    }

    IEnumerator Recharge()
    {
        yield return new WaitForSeconds(atkSpd);
        enRecharge = false;
        yield break;
    }
}
