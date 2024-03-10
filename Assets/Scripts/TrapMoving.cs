using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovingOpposite : MonoBehaviour
{
    public float speed = 2.0f; // 큐브의 이동 속도
    public float maxRange = 5.0f; // 큐브의 최대 이동 범위
    private float initialPosition; // 큐브의 초기 위치
    public bool moveXplus = true; // 왼쪽으로 먼저 이동할지 여부

    void Start()
    {
        initialPosition = transform.position.x; // 초기 위치 설정
    }

    void Update()
    {
        float movement;
        // Mathf.PingPong 함수를 사용하여 왔다갔다 이동 구현
        if (moveXplus)
        {
            movement = Mathf.PingPong(Time.time * speed, maxRange * 2) - maxRange;
        }
        else
        {
            // 오른쪽을 기준으로 시작하려면, PingPong의 결과값을 반전시킵니다.
            movement = -Mathf.PingPong(Time.time * speed, maxRange * 2) + maxRange;
        }
        transform.position = new Vector3(initialPosition + movement, transform.position.y, transform.position.z);
    }
}