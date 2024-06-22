using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float boostSpeed = 15f;
    [SerializeField] GameObject Boost;
    void Start()
    {
        
    }
 void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject != Boost){
            moveSpeed = slowSpeed;
        }
    }

    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
         transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmout, 0);
    }

   
}

       