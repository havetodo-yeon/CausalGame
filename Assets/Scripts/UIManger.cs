using static UnityEditor.Progress;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Text")]
    public Text QuestText;
    public Text StageText;
    public Text DeathCountText;

    public static int item_count = 0;   // ���ӿ��� üũ�� ������ ����
    public int require_item_count;  // �䱸�ϴ� ������ ����
    public static int DeathCount;   // ���� ī��Ʈ

    [Header("Data")]
    public int current_stage;    // ���� Ŭ������ �������� ����
    public int Max_Stage;   // �ִ� �������� ����

    //public Item[] items;   // ������ �迭


    // Start is called before the first frame update
    void Start()
    {
        StageText.text = $"Stage : {current_stage} / {Max_Stage}";
        //items = FindObjectsOfType<Item>();
        //// ������ Ÿ���� ������Ʈ���� ���� ������ ã�Ƽ� ������ �迭�� ����մϴ�.
        //require_item_count = items.Length;
    }

    // Update is called once per frame
    void Update()
    {
        QuestText.text = $"Item : {item_count} / {require_item_count}";
        DeathCountText.text = $"Death count : {DeathCount}";

        // ������ ������ 0�� ��� ��ü ������ Ȱ��ȭ
        //if (item_count == 0)
        //{
        //    for (int i = 0; i < require_item_count; i++)
        //    {
        //        items[i].GetComponent<GameObject>().SetActive(true);
        //    }
        //}
    }
}
