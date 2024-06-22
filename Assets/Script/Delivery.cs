using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    [SerializeField] float destroyDelay = 0.5f;
    bool X = false;

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Ouch!");
    }

     void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Package" && !X){
        Debug.Log("Picked Up");
        X = true;
        Destroy(other.gameObject, destroyDelay);
        spriteRenderer.color = hasPackageColor;
       
    }
    if(other.tag == "Customer" && X == true){
        Debug.Log("U did it!");
        X = false;
        spriteRenderer.color = noPackageColor;
    }
  }
}

