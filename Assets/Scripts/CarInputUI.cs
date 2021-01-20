using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

 
public class CarInputUI : MonoBehaviour {
 
    public Button leftButton; // Assign in inspector.
    public Button rightButton;

    ButtonPress lb;
    ButtonPress rb;
    private float steeringValue = 0;
    private float steeringVelocity = 0;
 
    public float Steering() {
        return steeringValue;
    }

    void Start(){
        lb = leftButton.GetComponent<ButtonPress>();
        rb = rightButton.GetComponent<ButtonPress>();
    }

    void Update() {
        Debug.Log("l " + leftButton.GetComponent<ButtonPress>().pressed);
        Debug.Log("r " + rightButton.GetComponent<ButtonPress>().pressed);
        // If left and right buttons cancel each other out, don't do anything:
        if (lb.pressed == rb.pressed) return;
 
        // Otherwise smoothly adjust toward target value:
        var target = 0;
        if (lb.pressed) target = -1;
        else if (rb.pressed) target = 1;
        steeringValue = Mathf.SmoothDamp(steeringValue, target, ref steeringVelocity, 1);
        Debug.Log(steeringValue);
    }    
}