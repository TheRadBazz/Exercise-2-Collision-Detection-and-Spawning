using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float mass = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(mass, mass, mass);

    }

}
