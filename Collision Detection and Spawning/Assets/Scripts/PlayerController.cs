using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.2f;
    Vector3 velocity;
    public float mass = 1;

    void Update()
    {
        Vector3 input;
        string horizontalInputName;
        string verticalInputName;

        if (gameObject.CompareTag("Player1"))
        {
            horizontalInputName = "HorizontalPrimary";
            verticalInputName = "VerticalPrimary";
        }
        else if (gameObject.CompareTag("Player2"))
        {
            horizontalInputName = "HorizontalSecondary";
            verticalInputName = "VerticalSecondary";
        }
        else
        {
            Debug.LogWarning("GameObject does not have Player1 or Player2 tag assigned.");
            return;
        }

        input = new Vector3(Input.GetAxis(horizontalInputName), Input.GetAxis(verticalInputName), 0);
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
