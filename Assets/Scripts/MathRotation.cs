using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathRotation : MonoBehaviour
{
    float euler;

    // Update is called once per frame
    void Update()
    {
        euler += Time.deltaTime;
        // transform.position = Getposition(euler * 100, 15);
        transform.position = Getposition3D(euler * 100, 15);
    }
    Vector3 Getposition(float angle, float radius)
    {
        float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
        float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;

        Debug.Log($"x: {x}, z: {z}");

        return new Vector3(x, 0, z);
    }

    Vector3 Getposition3D(float angle, float radius)
    {
        float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
        float y = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
        float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;

        return new Vector3(x, y, z);
    }
}
