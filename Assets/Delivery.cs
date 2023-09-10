using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    [SerializeField] Color32 hasPackageColor = new Color32(255,255,255,255);
    [SerializeField] Color32 noPackageColor = new Color32(255,255,255,255);

    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    [SerializeField] float destroyDelay = 0.1f;
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OUCH");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Picked up package");
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        } else if(other.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package Deliverd");
        }
    }
}
