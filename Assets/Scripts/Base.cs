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
        mesh.material = mesh.materials[0];
        Debug.Log("Select");

        if (Input.GetKeyDown(KeyCode.Alpha1) && !occuper && Data.Gold >= 1)
        {
            Instantiate(tourTir, transform);
            Data.Gold -= 1;
            mesh.enabled = false;
            occuper = true;
            Debug.Log("Tour");
            selectionner = false;
            mesh.material = mesh.materials[1];
            Debug.Log("Unselect");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && !occuper && Data.Gold >= 4)
        {
            Instantiate(glace, transform);
            Data.Gold -= 4;
            mesh.enabled = false;
            occuper = true;
            Debug.Log("Glace");
            selectionner = false;
            mesh.material = mesh.materials[1];
            Debug.Log("Unselect");
        }

        if (Input.GetKeyDown(KeyCode.E) && !occuper && Data.Gold >= 10)
        {
            Instantiate(bombe, transform);
            Data.Gold -= 10;
            mesh.enabled = false;
            occuper = true;
            Debug.Log("Bombe");
        }

        if (Input.GetKeyDown(KeyCode.X) && occuper)
        {
            if (tourTir != null)
                Destroy(tourTir);
            else if (glace != null)
                Destroy(glace);
            else if (bombe != null)
                Destroy(bombe);
            
            mesh.enabled = true;
            occuper = false;
            Debug.Log("Supprimer");
        }
    }

    
}
