using UnityEngine;

public class SunScale : MonoBehaviour
{
    public AnimationCurve sunCurve;
    float timeScale;
    Vector3 startScale;
    bool isGrowing = true;

    void Start()
    {
        startScale = transform.localScale;
        timeScale = 0f;
    }

    void Update()
    {
        //Sun scales up and down all the time
        if (isGrowing)
        {
            timeScale += Time.deltaTime * 0.5f; //time scale not to fast
            if (timeScale >= 1f)
            {
                isGrowing = false;
            }
        }
        else
        {
            timeScale -= Time.deltaTime * 0.5f; //time scale not to fast
            if (timeScale <= 0f)
            {
                isGrowing = true;
            }
        }

        float curveValue = sunCurve.Evaluate(timeScale);
        transform.localScale = startScale * curveValue;
    }
}