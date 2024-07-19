using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup1 : MonoBehaviour
{
    public float mass = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(mass, mass, mass);

    }

}
