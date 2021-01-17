using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    public InputManager input;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 2000f;
    public float maxTurn = 20000f;
    public float vel = 10f;

    void Start()
    {        
        input = GetComponent<InputManager>();
    }
    
    void FixedUpdate()
    {        
        foreach (WheelCollider wheel in throttleWheels)
        {            
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * input.throttle * vel; 
        }

        foreach (WheelCollider wheel in steeringWheels)
        {            
            wheel.steerAngle = maxTurn * input.steer; 
        }
    }
}



    /*
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
    */

