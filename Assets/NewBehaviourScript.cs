using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello unity");

        //1.����
        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        //Debug.Log("����� �̸���?");
        //Debug.Log(playerName);
        //Debug.Log("����� ������?");
        //Debug.Log(level);
        //Debug.Log("����� ����?");
        //Debug.Log(strength);
        //Debug.Log("���� �����ΰ�?");
        //Debug.Log(isFullLevel);

        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 6;
        monstersLevel[2] = 20;

        //Debug.Log("�ʿ� �����ϴ� ����");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);

        //Debug.Log("�ʿ� �����ϴ� ������ ����");
        //Debug.Log(monstersLevel[0]);
        //Debug.Log(monstersLevel[1]);
        //Debug.Log(monstersLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        //Debug.Log("������ �ִ� ������");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //items.RemoveAt(0);

        //Debug.Log("������ �ִ� ������");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //3. ������
        int exp = 1500;


    }
        // Update is called once per frame
        void Update()
        {

        }
}
