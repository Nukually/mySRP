using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightPosController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f; // ������ת�ٶȵı���

    private float timePassed = 0f; // ���ڼ���PingPongֵ��ʱ�����

    void Update()
    {
        // ���¾�����ʱ��
        timePassed += Time.deltaTime * speed;

        // ʹ��Mathf.PingPong����ʹֵ��0��100֮������
        float rotationX = Mathf.PingPong(timePassed, 50f);

        // ���õƹ����ת
        transform.rotation = Quaternion.Euler(rotationX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
