using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float speed = 0.1f;
    

    // Update is called once per frame
    void Update() {
        if (OVRInput.Get(OVRInput.Button.DpadRight))
       //if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (OVRInput.Get(OVRInput.Button.DpadLeft))
       //if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
         if (OVRInput.Get(OVRInput.Button.DpadUp))
       // if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }
         if (OVRInput.Get(OVRInput.Button.DpadDown))
        //if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y - speed, transform.position.z);
        }
    }
}
