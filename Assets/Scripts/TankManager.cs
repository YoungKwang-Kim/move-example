using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    [SerializeField] GameObject tank;

    float newAngle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"Mouse Position x: {Input.mousePosition.x}, y: {Input.mousePosition.y}");

            Vector3 tankScreenPoint = Camera.main.WorldToScreenPoint( tank.transform.position );

            Debug.Log($"Tank Position x: {tankScreenPoint.x}, y: {tankScreenPoint.y}");

            Vector3 diff = Input.mousePosition - tankScreenPoint;

            float angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            newAngle = 90.0f - angle;
        }

        // transform.eulerAngles = new Vector3() ��ü�� ȸ������
        // Mathf.LerpAngle(ȸ����, ȸ���� ����, ȸ���ϴµ� �ɸ��� �ð�)
        tank.transform.eulerAngles = new Vector3(0, Mathf.LerpAngle(tank.transform.eulerAngles.y, newAngle, Time.deltaTime * 10.0f), 0f);

        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");
        float moveSpeed = 10.0f;
        Vector3 moveVec = new Vector3(xAxis, 0, zAxis).normalized;

        tank.transform.position += moveVec * moveSpeed * Time.deltaTime;
    }
}