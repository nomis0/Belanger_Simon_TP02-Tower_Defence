using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourTir : Tours, ITours
{
    
    // Constructeur
    public TourTir()
    {
        degats = 2;
        cout = 1;
        atkSpd = 1f;
        enRecharge = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // S'il s'agit d'un IEnnemies
        Ennemie ennemie = other.GetComponentInParent<Ennemie>();

        if (ennemie != null)
        {
            //Si on peut tirer...
            if (!enRecharge)
            {
                // On tire
                Tirer(ennemie);
            }
        }
    }

    public void Tirer(Ennemie ennemie)
    {
        IEnnemies mechant = ennemie.GetComponentInParent<IEnnemies>();
        mechant.Touché(ennemie);
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
