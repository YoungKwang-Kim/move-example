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
        // 자전
        // 예시로 x축을 중심으로 돌고 싶으면 x이외에 0으로 설정
        transform.rotation = Quaternion.Euler(0, jaSpeed, 0);
        // 공전
        // RotateAround(중심점, 중심축, 회전각도)
        transform.RotateAround(earth.position, Vector3.up, gonSpeed * Time.deltaTime);
    }
}
