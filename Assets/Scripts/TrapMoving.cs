using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovingOpposite : MonoBehaviour
{
    public float speed = 2.0f; // ť���� �̵� �ӵ�
    public float maxRange = 5.0f; // ť���� �ִ� �̵� ����
    private float initialPosition; // ť���� �ʱ� ��ġ
    public bool moveXplus = true; // �������� ���� �̵����� ����

    void Start()
    {
        initialPosition = transform.position.x; // �ʱ� ��ġ ����
    }

    void Update()
    {
        float movement;
        // Mathf.PingPong �Լ��� ����Ͽ� �Դٰ��� �̵� ����
        if (moveXplus)
        {
            movement = Mathf.PingPong(Time.time * speed, maxRange * 2) - maxRange;
        }
        else
        {
            // �������� �������� �����Ϸ���, PingPong�� ������� ������ŵ�ϴ�.
            movement = -Mathf.PingPong(Time.time * speed, maxRange * 2) + maxRange;
        }
        transform.position = new Vector3(initialPosition + movement, transform.position.y, transform.position.z);
    }
}