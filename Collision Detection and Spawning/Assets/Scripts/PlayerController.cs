using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.2f;
    Vector3 velocity;
    public float mass = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("HorizontalPrimary"),
            Input.GetAxis("VerticalPrimary"), 0);

        Vector3 direction = input.normalized;
        velocity = direction * speed;

        transform.localScale = new Vector3(mass, mass, mass);
    }

    private void FixedUpdate()
    {
        transform.Translate(velocity);
    }
    private void OnTriggerEnter(Collider triggerCollider)
    {
        if(triggerCollider.tag == "Pickup")
        {
            Pickup pickup = triggerCollider.GetComponentInParent<Pickup>();
            mass += pickup.mass;
            Destroy(triggerCollider.gameObject);


            GetComponent<UnityEngine.Camera>().orthographicSize =
                Screen.height *.2f;
        }
        
    }

}
