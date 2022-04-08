using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private bool occuper = false;
    private bool selectionner = false;
    public MeshRenderer mesh;
    public GameObject tourTir;
    public GameObject glace;
    public GameObject bombe;
    public Main main;
    


    private void OnMouseDown()
    {
        selectionner = true;
        Debug.Log("Select");

        main.BaseSelectionner(selectionner);
    }    
}
