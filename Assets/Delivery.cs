using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OUCH");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Package"))
        {
            Debug.Log("Picked up package");
        } else if(other.CompareTag("Customer"))
            Debug.Log("Package Deliverd");
    }
}
