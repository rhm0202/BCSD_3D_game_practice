using UnityEngine;


public class LifeCucle2 : MonoBehaviour
{
    //void Update()
    //{
    //    if (Input.anyKeyDown) Debug.Log("�÷��̾ �ƹ�Ű�� �������ϴ�.");
    //    //if (Input.anyKey) Debug.Log("�÷��̾ �ƹ�Ű�� ������ �ֽ��ϴ�.");

    //    //if (Input.GetKeyDown(KeyCode.Return)) Debug.Log("�������� �����Ͽ����ϴ�."); // ����Ű
    //    //if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("�������� �̵� ��.");
    //    //if (Input.GetKeyUp(KeyCode.RightArrow)) Debug.Log("������ �̵��� ���߾����ϴ�.");

    //    //if (Input.GetMouseButtonDown(0)) Debug.Log("�̻��� �߻�!");
    //    //if (Input.GetMouseButton(0)) Debug.Log("�̻��� ������ ��...");
    //    //if (Input.GetMouseButtonUp(0)) Debug.Log("���� �̻��� �߻�!");

    //    //if (Input.GetButtonDown("Jump")) Debug.Log("����!");
    //    //if (Input.GetButton("Jump")) Debug.Log("���� ������ ��!");
    //    //if (Input.GetButtonUp("Jump")) Debug.Log("���� ����!");

    //    if (Input.GetButton("Horizontal")) {
    //        Debug.Log("Ⱦ �̵���..." + Input.GetAxis("Horizontal"));
    //    }

    //    if (Input.GetButton("Vertical"))
    //    {
    //        Debug.Log("�� �̵���..." + Input.GetAxis("Vertical"));
    //    }

    //}

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
