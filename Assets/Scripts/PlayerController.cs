using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    public string sceneName;

    public List<GameObject> items = new List<GameObject>(); // 아이템 오브젝트 리스트

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        //if (gameObject.transform.position.z <= 10.0f && gameObject.transform.position.z >= 0.0f
        //    && gameObject.transform.position.x <= 12.0f && gameObject.transform.position.x >= 0.0f )
        //{
        //    }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            items.Add(other.gameObject); // 아이템 리스트에 추가
            other.gameObject.SetActive(false);
            UIManager.item_count++;
        }
        if (other.gameObject.tag == "Trap")
        {
            UIManager.item_count = 0;
            UIManager.DeathCount++;
            // 장애물에 부딪힐 경우 스폰 지역으로 이동
            gameObject.transform.position = new Vector3(0, 1, 0);

            foreach (GameObject item in new List<GameObject>(items)) // 복사본을 순회
            {
                items.Remove(item); // 참조를 먼저 제거
                item.SetActive(true);
            }
            items.Clear(); // 아이템 리스트 초기화
        }

        if(other.gameObject.tag == "Goal")
        {
             SceneManager.LoadScene(sceneName);
        }
    }
}
