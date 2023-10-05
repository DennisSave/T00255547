using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class soldermovment : MonoBehaviour
{
    // Start is called before the first frame update
    Animator myAnimator;
    float currentspeed, walkingspeed = 3, runningspeed = 6;
    private float turningSpeed = 180;


    void Start()
    {
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
    }
}