using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : Tours, ITours
{

    // Constructeur
    public Bombe()
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

        enRecharge = true;
        StartCoroutine(Recharge());
    }

    IEnumerator Recharge()
    {
        yield return new WaitForSeconds(atkSpd);
        enRecharge = false;
        yield break;
    }

    IEnumerator Exploser()
    {
        yield return new WaitForSeconds(1.5f);

        //Explose

        yield break;
    }
}
