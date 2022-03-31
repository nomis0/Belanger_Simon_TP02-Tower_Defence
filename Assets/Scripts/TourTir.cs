using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourTir : Tours, ITours
{
    public Transform tour;
    public LineRenderer tir_trail;

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
        IEnnemies ennemie = other.GetComponentInParent<IEnnemies>();
        Transform transf_ennemie = other.GetComponentInParent<Transform>();

        if (ennemie != null)
        {
            Tirer(ennemie, transf_ennemie);
        }
    }

    public void Tirer(IEnnemies ennemie, Transform transf_ennemie)
    {
        // bullet trail A
        tir_trail.SetPosition(0, tour.position);

        // Je crée un rayon
        Ray fireRay = new Ray(tour.position, transf_ennemie.position);

        // Cast le rayon
        Physics.Raycast(fireRay);

        if (ennemie != null)
        {
            ennemie.Touché();
        }
        
    }
}
