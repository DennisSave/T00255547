using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecrontrolscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //s = u t     s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += 5f * transform.forward * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up,-90*Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);
        }

    }
}
    