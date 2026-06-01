using UnityEngine;

public class SquareMover : MonoBehaviour
{
   public float speed = 0.01f*Time.deltaTime;
    float xMax = 8.30f;
    float xMin = -8.30f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We can get access to the Transform component by typing "transform"
        //transform.position.x += 1f; //wrong aproach to code

        Vector3 newPosition = transform.position; //first we need to get a vector
        newPosition.x += speed; // f means float, if you gonna have numbers like 2,45..put f at the end
        transform.position = newPosition;
        if (newPosition.x > xMax)
        {
            speed = -0.01f*Time.deltaTime;
            // speed = - speed; // other option
        }
        if (newPosition.x < xMin)
        {
            speed = 0.01f*Time.deltaTime;
        }
    }
}
