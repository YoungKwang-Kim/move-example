using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public float speed;

    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
        // ����ĳ��Ʈ�� �Ķ���ͷ� ���� out Ű����� ������ �ô� ����(Ray)��
        // ��ü�� �浹�ϴ� ������ Hit Point�� RaycastHit ����ü ����(hit)�� ����شٴ� ��
            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                Debug.Log("Target Position: " + targetPosition);
            }
        }

        // ���� + �Ÿ������� ��������
        Vector3 dir = targetPosition - transform.position;
        // Normalize()�� �Ÿ����� �ʱ�ȭ
        dir.Normalize();
        dir = new Vector3(dir.x, 0, dir.z);
        dir *= speed * Time.deltaTime;

        transform.position += dir;
    }
}
