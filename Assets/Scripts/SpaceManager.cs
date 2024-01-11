using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{
    [SerializeField] Transform sun;
    [SerializeField] Transform earth;
    [SerializeField] Transform venus;
    [SerializeField] Transform jupyter;

    float gongSpeed = 0.0f;
    float jaSpeed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Sun();
        Earth();
        Venus();
        Jupyter();
    }

    void Sun()
    {

    }

    void Earth()
    {
        // 자전
        jaSpeed += 10 * Time.deltaTime;
        earth.rotation = Quaternion.Euler(0, jaSpeed, 0);

        // 공전
        gongSpeed = 30.0f;
        earth.RotateAround(sun.position, Vector3.up, gongSpeed * Time.deltaTime);
    }

    void Venus()
    {
        gongSpeed = 15.0f;
        venus.RotateAround(sun.position, Vector3.up, gongSpeed * Time.deltaTime);
    }

    void Jupyter()
    {
        gongSpeed = 20.0f;
        jupyter.RotateAround(sun.position, Vector3.up, gongSpeed * Time.deltaTime);
    }
}
