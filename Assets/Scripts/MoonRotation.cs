using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    [SerializeField] Transform earth;
    float gonSpeed = 50.0f;
    float jaSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jaSpeed += 100.0f * Time.deltaTime;
        // ����
        // ���÷� x���� �߽����� ���� ������ x�̿ܿ� 0���� ����
        transform.rotation = Quaternion.Euler(0, jaSpeed, 0);
        // ����
        // RotateAround(�߽���, �߽���, ȸ������)
        transform.RotateAround(earth.position, Vector3.up, gonSpeed * Time.deltaTime);
    }
}
