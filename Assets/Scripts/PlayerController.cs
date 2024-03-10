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

    public List<GameObject> items = new List<GameObject>(); // ������ ������Ʈ ����Ʈ

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
            items.Add(other.gameObject); // ������ ����Ʈ�� �߰�
            other.gameObject.SetActive(false);
            UIManager.item_count++;
        }
        if (other.gameObject.tag == "Trap")
        {
            UIManager.item_count = 0;
            UIManager.DeathCount++;
            // ��ֹ��� �ε��� ��� ���� �������� �̵�
            gameObject.transform.position = new Vector3(0, 1, 0);

            foreach (GameObject item in new List<GameObject>(items)) // ���纻�� ��ȸ
            {
                items.Remove(item); // ������ ���� ����
                item.SetActive(true);
            }
            items.Clear(); // ������ ����Ʈ �ʱ�ȭ
        }

        if(other.gameObject.tag == "Goal")
        {
             SceneManager.LoadScene(sceneName);
        }
    }
}
