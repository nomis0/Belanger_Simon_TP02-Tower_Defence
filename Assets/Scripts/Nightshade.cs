using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nightshade : Ennemie, IEnnemies
{
    public AudioSource sourceNight;
    public AudioClip clipMortNight;
    public Transform transf_ennemie;

    NavMeshAgent agent;
    Vector3 destination = new Vector3(10f, 1.99f, -57.25f);

    Rigidbody[] rbs;
    Animator animator;

    //Constructeur
    public Nightshade(int nbVague)
    {
        Gold = 2;
        vitesse = 3;
        pv = 2 + nbVague / 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        rbs = GetComponentsInChildren<Rigidbody>();
        animator = GetComponent<Animator>();

        // Désactiver le ragdoll
        ActiverRagdoll(false);

        Deplacer();
    }

    public void Deplacer()
    {
        agent.SetDestination(destination);
    }

    public void Touché()
    {
        pv -= 1;

        if (pv <= 0)
        {
            Meurs();
        }
    }

    void Meurs()
    {
        // Activer le ragdoll
        ActiverRagdoll(true);
    }

    void ActiverRagdoll(bool value)
    {
        // Activer/Désactiver les rigidbodies
        foreach (var r in rbs)
        {
            r.isKinematic = !value;
        }

        // Activer/Désactiver l'Animator
        animator.enabled = !value;
    }
}
