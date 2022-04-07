using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class Skeleton : Ennemie, IEnnemies
{
    public AudioSource sourceSkeleton;
    public AudioClip clipMortSkeleton;
    public Transform transf_ennemie;

    NavMeshAgent agent;

    Rigidbody[] rbs;
    Animator animator;

    //Constructeur
    public Skeleton(int nbVague)
    {
        Gold = 1;
        vitesse = 2;
        pv = 1 + nbVague / 2;
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
        agent.SetDestination(new Vector3(10f, 1.99f, -57.25f));
    }

    public void Touché(Ennemie ske)
    {
        pv -= 1;

        if (pv <= 0)
        {
            Meurs(ske);
        }
    }

    void Meurs(Ennemie ske)
    {
        // Activer le ragdoll
        ActiverRagdoll(true);
        Data.ennemieMort += 1;
        Data.Gold += 1;
        Data.EnnemieTue(ske);
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
