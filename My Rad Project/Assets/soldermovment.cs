using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class soldermovment : MonoBehaviour
{
    // Start is called before the first frame update
    Animator myAnimator;
    float jumpForce = 2;
    float currentspeed, walkingspeed = 3;
    float runningspeed, running = 6;
    private float turningSpeed = 180;
    Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        runningspeed = running;
        currentspeed = walkingspeed;
        myAnimator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetBool("iswalking", false);

        //s = u t     s- distance = u (velocity) * t (time)


        if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetBool("iswalking", true);
            transform.position += currentspeed * transform.forward * Time.deltaTime;
                }



        if (Input.GetKey(KeyCode.S))
        {

            transform.position -= currentspeed * transform.forward * Time.deltaTime;



        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up, -90* Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up,  90* Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            myAnimator.SetBool("iswalking", true);
            transform.position += runningspeed * transform.forward * Time.deltaTime;
            
        
        
        }

        if(Input.GetKey(KeyCode.Space))
        {


            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        }


        
    
    
    
    
    
    
    
    
    
    
    }
}