using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tours : MonoBehaviour
{
    protected int degats { get { return degats; } set { value = degats; } }
    protected int cout { get { return cout; } set { value = cout; } }
    protected int atkSpd { get { return atkSpd; } set { value = cout; } }

    public virtual void tirer(GameObject ennemie)
    {
        // tire sur ennemie qui est entré dans le collider

    }
}
