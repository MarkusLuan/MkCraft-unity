using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    private float xDeg = 0;
    private float yDeg = 0;

    // Update is called once per frame
    void Update()
    {
        xDeg += Input.GetAxis("Mouse X") * 2;
        yDeg -= Input.GetAxis("Mouse Y") * 2;
        transform.rotation = Quaternion.Euler(yDeg, xDeg, 0);
    }
}
