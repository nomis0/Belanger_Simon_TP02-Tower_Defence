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

    private void OnMouseDown()
    {
        selectionner = true;
        Data.selectionner = true;
        Debug.Log("Select");
        Data.BaseSelect = name;
        Debug.Log($"{name}");
    }    
}
