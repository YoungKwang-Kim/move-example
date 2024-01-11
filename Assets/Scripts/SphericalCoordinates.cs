using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalCoordinates
{
    //반지름
    float radius;

    //방위각
    float azimuth;

    //양각
    float elevation;

    public SphericalCoordinates(Vector3 cartesianCoordinates)
    {
        // 지점까지의 거리
        radius = cartesianCoordinates.magnitude;

        //방위각
        azimuth = Mathf.Atan2(cartesianCoordinates.z, cartesianCoordinates.x);

        //양각
        elevation = Mathf.Asin(cartesianCoordinates.y / radius);
    }

    // 구면좌표계를 직교좌표계로 변환하는 코드
    public Vector3 ToCartesian
    {
        get 
        {
            float a = radius * Mathf.Cos(elevation);
            return new Vector3(a * Mathf.Cos(azimuth), radius * Mathf.Sin(elevation), a * Mathf.Sin(azimuth));
        }
    }

    public SphericalCoordinates Rotate(float newAzimuth, float newElevation)
    {
        azimuth += newAzimuth;
        elevation += newElevation;
        return this;
    }

}