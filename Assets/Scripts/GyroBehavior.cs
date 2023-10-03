using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroBehavior : MonoBehaviour
{

    private Quaternion gyroQuat;

    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        gyroQuat = GyroToUnity(Input.gyro.attitude);

        if (gyroQuat.x > 0)
        {
            Physics2D.gravity = new Vector2(-9.8f, -9.8f);
        }
        else if (gyroQuat.x < 0 )
        {
            Physics2D.gravity = new Vector2(9.8f, -9.8f);
        }
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
