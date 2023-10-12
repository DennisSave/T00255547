using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullets : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
   public Transform spawnPoint;
   public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Fire1"))
        {
           var bullet = Instantiate(Bullet, spawnPoint.position, spawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * 30;
             
        
        }

    }
     
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name =="enemy") 
        {
            print("ouch");


        }
    }
    internal void ImThrowingYou(soldermovment char_Control)



     {

        transform.position = char_Control.transform.position + Vector3.up + 3 * char_Control.transform.forward;


        rb = GetComponent<Rigidbody>();
        rb.velocity =2 *(Vector3.up +4* char_Control.transform.forward);


     }











}


