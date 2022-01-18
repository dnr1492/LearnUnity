using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float radius = 1.0f;  // �÷��̾��� �ݰ�(������), �������� �����Ͽ� �浹 ������ ���� ����

    private GameDirector gameDirector;
    public float maxHp;
    public float hp;

    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
        this.hp = this.maxHp;
    }

    void Update()
    {
        if (this.gameDirector.isGameOver) return;

        // Ű���� ���� ȭ��ǥ�� ������
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);  // x�� �������� 3 �����δ�
        }

        // Ű���� ������ ȭ��ǥ�� ������
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);  // x�� ���������� 3 �����δ�
        }

        // �÷��̾ ȭ�� ������ �� ������ �ϴ� ��� 1
        // ī�޶��� ���� �ϴ��� (0,0 , 0.0) �̸�, ���� ����� (1.0 , 1.0)
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.05f) pos.x = 0.05f;
        if (pos.x > 0.95f) pos.x = 0.95f;
        //if (pos.y < 0.1f) pos.y = 0.1f;
        //if (pos.y > 0.9f) pos.y = 0.9f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    // ���� UI ȭ��ǥ�� Ŭ���ϸ�
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);  // x�� �������� 1 �����δ�

        // �÷��̾ ȭ�� ������ �� ������ �ϴ� ��� 2
        //if (this.transform.position.x <= -7.82f)
        //{
        //    var pos = this.transform.position;
        //    pos.x = -7.82f;
        //    this.transform.position = pos;
        //}
    }

    // ������ UI ȭ��ǥ�� Ŭ���ϸ�
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);  // x�� ���������� 1 �����δ�

        // �÷��̾ ȭ�� ������ �� ������ �ϴ� ��� 2
        //if (this.transform.position.x >= 7.77f)
        //{
        //    var pos = this.transform.position;
        //    pos.x = 7.77f;
        //    this.transform.position = pos;
        //}
    }

    // �浹 ���� ����뿡 ����
    // ��ü �����
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}
