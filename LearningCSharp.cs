using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LearningCSharp : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        float distance = GetDistanceBetweenTwoPoints(5, 6, 20, 15);

        print(distance);

    }

    // Update is called once per frame
    void Update()
    {

    }

    float GetDistanceBetweenTwoPoints(float x1, float y1, float x2, float y2)
    {
        float DX = x2 - x1;
        float DY = y2 - y1;
        float resultantDistance = DX * DX + DY * DY;
        float distance = Mathf.Sqrt(resultantDistance);
        return distance;
    }
}
