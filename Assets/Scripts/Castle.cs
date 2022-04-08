using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public Main main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Ennemie ennemie = other.GetComponentInParent<Ennemie>();
        main.EnnemieArriver(ennemie);
    }
}
