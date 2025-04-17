using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int health = 30;
    int level = 5;
    float strength = 15.5f;
    string playerName = "���˻�";
    bool isFullLevel = false;
    int fullLevel = 99;
    string title = "������";
    int exp = 1500;
    int mana = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello unity");

        //1.����
        //int level = 5;
        //float strength = 15.5f;
        //string playerName = "���˻�";
        //bool isFullLevel = false;

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
        //int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        //Debug.Log("����� �� ����ġ��?");
        //Debug.Log(exp);
        //Debug.Log("����� ������?");
        //Debug.Log(level);
        //Debug.Log("����� ����?");
        //Debug.Log(strength);

        int nextExp = 300-(exp % 300);

        //Debug.Log("���� �������� ���� ����ġ��?");
        //Debug.Log(nextExp);

        //string title = "������";
        //Debug.Log("����� �̸���?");
        //Debug.Log(playerName);
        //Debug.Log(title + " " + playerName);

        //int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("���� �����Դϱ�? " +  isFullLevel);

        bool isEndTutorial = level > 10;
        //Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

        //int health = 30;
        //int mana = 15;

        bool isBadConditioon = health <= 50 || mana <= 20;

        string consition = isBadConditioon ? "����" : "����";
        //Debug.Log("����� ���°� ���޴ϱ�? " + consition);

        //4. Ű����
        //5. ���ǹ�
        if (consition == "����")
        {
            //Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���."); 
        }
        else
        {
            //Debug.Log("�÷��̾��� ���°� �����ϴ�.");
        }

        if (isBadConditioon && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            //Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if (isBadConditioon && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            //Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }

        string monsterAlarm;
        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            case "�Ǹ�":
                monsterAlarm =  "���� ���Ͱ� ����!";
                break;
            case "��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            default:
                monsterAlarm = "??? ���Ͱ� ����!";
                break;
        }
        //6. �ݺ���
        while (health > 0)
        {
            health--;
            //if (health > 0)
            //{
            //    Debug.Log("�� �������� �Ծ����ϴ�." + health);
            //}
            //else
            //{
            //    Debug.Log("����Ͽ����ϴ�.");
            //}

            if (health == 10)
            {
                //Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }

        //for (int count = 0; count < 10; count++)
        //{
        //    health++;

        //    Debug.Log("�ش�� ġ����..." + health);
        //}
        foreach (string monster in monsters)
        {
            //Debug.Log("�� ������ �ִ� ���� : " + monster);
        }

        //7. �޼ҵ�
        //health = Heal(health);

        //Heal();

        for (int i = 0; i < monsters.Length; i++)
        {
            //Debug.Log("���� " + monsters[i] + "���� " + Battle(monstersLevel[i]));
        }

        //8. Ŭ����
        player player = new player();
        player.id = 0;
        player.name = "�Ϲ���";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + "�Դϴ�.");

        Debug.Log(player.move());
    }

    //7. �Լ�(�޼ҵ�)
    //int Heal(int health)
    //{
    //    health += 10;
    //    Debug.Log("���� �޾ҽ��ϴ�." +  health);
    //    return health;
    //}

    void Heal()
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�." +  health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }

    // Update is called once per frame
    void Update()
        {

        }
}
