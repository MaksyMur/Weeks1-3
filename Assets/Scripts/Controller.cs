using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float speed;
    public float rSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpHeld = Keyboard.current.upArrowKey.isPressed;
        if (isUpHeld)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            bool isDownHeld = Keyboard.current.downArrowKey.isPressed;
            if (isDownHeld)
            {
                transform.position -= transform.up * speed * Time.deltaTime;
            }

            bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
            if (isLeftHeld)
            {
                transform.eulerAngles += transform.forward * rSpeed * Time.deltaTime;
            }


        }
    }
}
