using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightPosController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f; // 控制旋转速度的变量

    private float timePassed = 0f; // 用于计算PingPong值的时间变量

    void Update()
    {
        // 更新经过的时间
        timePassed += Time.deltaTime * speed;

        // 使用Mathf.PingPong函数使值在0到100之间往复
        float rotationX = Mathf.PingPong(timePassed, 50f);

        // 设置灯光的旋转
        transform.rotation = Quaternion.Euler(rotationX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
