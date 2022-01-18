using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // �� �����Ӹ��� ������� ���� (y���̹Ƿ� �Ʒ���)
        transform.Translate(0, -0.1f, 0);
        //transform.Translate(0, 0.1f, 0);  // �� �����Ӹ��� ������� ��� (y���̹Ƿ� ����)

        // ȭ�� ������ ������ ���� ������Ʈ�� ȭ��ǥ�� �Ҹ��Ų��
        if (transform.position.y < -3.99f)
        {
            Destroy(gameObject);
        }

        // �浹 ����
        Vector2 p1 = transform.position;  // ȭ���� �߽� ��ǥ. ��, ȭ���� ��ġ
        Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ. ��, �÷��̾��� ��ġ
        Vector2.Distance(p2, p1);
        Vector2 dir = p2 - p1;  // p1 - p2
        float d = dir.magnitude;
        float r1 = 0.5f;  // ȭ���� �ݰ�(������)
        float r2 = 1.0f;  // �÷��̾��� �ݰ�(������)
        if (d < r1 + r2)
        {
            // ���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� �����Ѵ�
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            // �浹�� ��� ���� ������Ʈ�� ȭ��ǥ�� �Ҹ��Ų��
            Destroy(gameObject);
        }

    }
}
