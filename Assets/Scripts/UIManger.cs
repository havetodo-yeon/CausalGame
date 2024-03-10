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

    public static int item_count = 0;   // 게임에서 체크할 아이템 개수
    public int require_item_count;  // 요구하는 아이템 개수
    public static int DeathCount;   // 데스 카운트

    [Header("Data")]
    public int current_stage;    // 현재 클리어한 스테이지 정보
    public int Max_Stage;   // 최대 스테이지 구현

    //public Item[] items;   // 아이템 배열


    // Start is called before the first frame update
    void Start()
    {
        StageText.text = $"Stage : {current_stage} / {Max_Stage}";
        //items = FindObjectsOfType<Item>();
        //// 아이템 타입의 오브젝트들을 게임 내에서 찾아서 아이템 배열에 등록합니다.
        //require_item_count = items.Length;
    }

    // Update is called once per frame
    void Update()
    {
        QuestText.text = $"Item : {item_count} / {require_item_count}";
        DeathCountText.text = $"Death count : {DeathCount}";

        // 아이템 개수가 0일 경우 전체 아이템 활성화
        //if (item_count == 0)
        //{
        //    for (int i = 0; i < require_item_count; i++)
        //    {
        //        items[i].GetComponent<GameObject>().SetActive(true);
        //    }
        //}
    }
}
