using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α��� �߽��ϴ�.");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("���� ���!!");
    }

    private void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    private void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ� �Ͽ����ϴ�.");
    }

    private void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�.");
    }
}
