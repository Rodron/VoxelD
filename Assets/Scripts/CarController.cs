using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    Vector3 deltaPosition;
    Quaternion deltaRotation;
    float vel = .1f;
    float rotVel = .7f;
    Vector3 rot = new Vector3 (0,1,0); 
    
  
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            deltaPosition = gameObject.GetComponent<Transform>().position;
            deltaPosition += transform.forward * vel;
            gameObject.GetComponent<Transform>().position = deltaPosition;
            deltaPosition = gameObject.GetComponent<Transform>().position;
        }

        if (Input.GetKey(KeyCode.S)){
            deltaPosition = gameObject.GetComponent<Transform>().position;
            deltaPosition -= transform.forward * vel;
            gameObject.GetComponent<Transform>().position = deltaPosition;
            deltaPosition = gameObject.GetComponent<Transform>().position;
        }

        if (Input.GetKey(KeyCode.A)){     
            gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(gameObject.GetComponent<Transform>().rotation.eulerAngles + (rot * rotVel));
        }

        if (Input.GetKey(KeyCode.D)){
            gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(gameObject.GetComponent<Transform>().rotation.eulerAngles - (rot * rotVel));
        }
    }
}
