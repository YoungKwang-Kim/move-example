using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleManager : MonoBehaviour
{
    [SerializeField] GameObject capsule1;
    [SerializeField] GameObject capsule2;
    [SerializeField] GameObject capsule3;

    float value = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value += Time.deltaTime * 50.0f;
        // Deg2Rad = Degree to Radian
        // Degree = 30도, 40도 / Radian = 1/4파이, 3/2파이
        float sinWav = Mathf.Sin(Mathf.Deg2Rad * value);
        float cosWav = Mathf.Cos(Mathf.Deg2Rad * value);

        capsule1.transform.position = new Vector3(capsule1.transform.position.x, sinWav, capsule1.transform.position.z);
        capsule2.transform.position = new Vector3(capsule1.transform.position.x, cosWav, capsule2.transform.position.z);
        capsule3.transform.position = new Vector3(capsule1.transform.position.x, sinWav, capsule2.transform.position.z);
    }
}
