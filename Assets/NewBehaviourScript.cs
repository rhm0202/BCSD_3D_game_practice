using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello unity");

        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel);

        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 6;
        monstersLevel[2] = 20;

        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);

        //Debug.Log("맵에 존재하는 몬스터의 레벨");
        //Debug.Log(monstersLevel[0]);
        //Debug.Log(monstersLevel[1]);
        //Debug.Log(monstersLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        //Debug.Log("가지고 있는 아이템");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //items.RemoveAt(0);

        //Debug.Log("가지고 있는 아이템");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //3. 연산자
        int exp = 1500;


    }
        // Update is called once per frame
        void Update()
        {

        }
}
