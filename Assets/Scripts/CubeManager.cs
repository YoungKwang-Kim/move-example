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
        // 레이캐스트에 파라미터로 들어가는 out 키워드는 위에서 봤던 레이(Ray)가
        // 물체와 충돌하는 지점인 Hit Point를 RaycastHit 구조체 변수(hit)에 담아준다는 뜻
            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                Debug.Log("Target Position: " + targetPosition);
            }
        }

        // 방향 + 거리값까지 구해진다
        Vector3 dir = targetPosition - transform.position;
        // Normalize()로 거리값은 초기화
        dir.Normalize();
        dir = new Vector3(dir.x, 0, dir.z);
        dir *= speed * Time.deltaTime;

        transform.position += dir;
    }
}
