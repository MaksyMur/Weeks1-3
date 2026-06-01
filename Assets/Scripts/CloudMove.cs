using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 1f;

    float xMax = 8.3f;
    float xMin = -8.3f;

    void Start()
    {

    }

    void Update()
    {
        //Current position of a cloud
        Vector3 newPosition = transform.position;

        //Move cloud
        newPosition.x += speed * Time.deltaTime;

        
        transform.position = newPosition;

        //Change direction at edges
        if (newPosition.x > xMax)
        {
            speed = -speed;
        }

        if (newPosition.x < xMin)
        {
            speed = -speed;
        }
    }
}