using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourTir : Tours, ITours
{
    public Transform tour;
    public LineRenderer tir_trail;
    private RaycastHit hit;

    // Constructeur
    public TourTir(GameObject platteforme)
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
        Transform transf_ennemie = other.GetComponentInParent<Transform>();

        if (ennemie != null)
        {
            if (!enRecharge)
            { 
                Tirer(ennemie);
            }
        }
    }

    public void Tirer(Ennemie ennemie)
    {
        IEnnemies mechant = ennemie.GetComponentInParent<IEnnemies>();
        mechant.Touché(ennemie);
    }
}
