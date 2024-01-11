using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalCoordinates
{
    //������
    float radius;

    //������
    float azimuth;

    //�簢
    float elevation;

    public SphericalCoordinates(Vector3 cartesianCoordinates)
    {
        // ���������� �Ÿ�
        radius = cartesianCoordinates.magnitude;

        //������
        azimuth = Mathf.Atan2(cartesianCoordinates.z, cartesianCoordinates.x);

        //�簢
        elevation = Mathf.Asin(cartesianCoordinates.y / radius);
    }

    // ������ǥ�踦 ������ǥ��� ��ȯ�ϴ� �ڵ�
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