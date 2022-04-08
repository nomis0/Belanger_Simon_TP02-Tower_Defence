using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Warrok : Ennemie, IEnnemies
{
    public AudioSource sourceSkeleton;
    public AudioClip clipMortSkeleton;
    public Transform transf_ennemie;
    public Main main;

    NavMeshAgent agent;

    Rigidbody[] rbs;
    Animator animator;

    //Constructeur
    public Warrok(int nbVague)
    {
        Gold = 3;
        vitesse = 1;
        pv = 3 + nbVague/2;
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

    public void Touché(Ennemie war)
    {
        pv -= 1;

        if (pv <= 0)
        {
            Meurs(war);
        }
    }

    void Meurs(Ennemie war)
    {
        // Activer le ragdoll
        ActiverRagdoll(true);

        Data.ennemieMort += 1;
        Data.Gold += 1;
        main.EnnemieMort(war);
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
