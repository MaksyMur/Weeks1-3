using UnityEngine;

public class ButterflyMove : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;

    public float speed = 0.5f;

    float timer = 0f;
    int currentMove = 1;

    void Update()
    {
        //Increase timer slowly
        timer += Time.deltaTime * speed;

        //Move zig zag
        //Move from A to B
        if (currentMove == 1)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, timer);

            if (timer >= 1f)
            {
                timer = 0f;
                currentMove = 2;
            }
        }
        //Move from B to C
        else if (currentMove == 2)
        {
            transform.position = Vector3.Lerp(pointB.position, pointC.position, timer);

            if (timer >= 1f)
            {
                timer = 0f;
                currentMove = 3;
            }
        }
        //Move from C to D
        else if (currentMove == 3)
        {
            transform.position = Vector3.Lerp(pointC.position, pointD.position, timer);

            if (timer >= 1f)
            {
                timer = 0f;
                currentMove = 4;
            }
        }
    }
}