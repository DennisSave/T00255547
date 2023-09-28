using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class soldermovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()


       float currentspeed, walkingspeed = 3, runningspeed = 6;
       private float turningSpeed = 180
    {

        
    }

    // Update is called once per frame
    void Update()
   
      if(Input.GetKey(KeyCode W))
    {   myAnimator.SetBool("iswalking") 
       transform.position += currentspeed * transform.forward * Time.deltaTime

    }

      if (Input.GetKey(KeyCode S))
   {
  
    transform.position += currentspeed * transform.forward * Time.deltaTime

   }

      if (Input.GetKey(KeyCode A))
   {

    transform.position += currentspeed * transform.forward * Time.deltaTime

   }

     if (Input.GetKey(KeyCode A))
   {

      transform.position += currentspeed * transform.forward * Time.deltaTime
 
   }