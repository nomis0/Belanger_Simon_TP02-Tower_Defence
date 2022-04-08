using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTourTir : MonoBehaviour
{
    // reference le prefab
    public GameObject tour;

    public void Clic()
    {
        Instantiate(tour);
        Debug.Log("Instance");
    }
}
