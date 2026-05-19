using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       bool leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        bool leftMouseWasPressed = Mouse.current.leftButton.wasPressedThisFrame;
        bool leftMouseWasReleased = Mouse.current.leftButton.wasPressedThisFrame;


        //Direction B-A from this object towards the target
        Vector3 directionToTarget = target.position - transform.position;
        transform.up = directionToTarget;
    }
}
