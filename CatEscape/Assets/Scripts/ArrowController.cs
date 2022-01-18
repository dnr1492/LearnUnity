using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //GameObject player;
    private PlayerController player;
    public float radius = 0.5f;  // ȭ���� �ݰ�(������), �������� �����Ͽ� �浹 ������ ���� ����

    private GameDirector gameDirector;

    void Start()
    {
        //this.player = GameObject.Find("player");
        this.player = GameObject.FindObjectOfType<PlayerController>();

        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }

    void Update()
    {
        // �� �����Ӹ��� ������� ���� (-y���̹Ƿ� �Ʒ���)
        transform.Translate(0, -0.1f, 0);
        //transform.Translate(0, 0.1f, 0);  // �� �����Ӹ��� ������� ��� (+y���̹Ƿ� ����)

        // ȭ�� ������ ������ ���� ������Ʈ�� ȭ���� �Ҹ��Ų��
        if (transform.position.y < -3.99f)
        {
            if (!this.gameDirector.isGameOver)
            {
                this.gameDirector.IncreaseScore(10);
            }

            // ��ũ��Ʈ�� ȭ�쿡 �����Ƿ� ���⼭ gameObject �� ȭ���� �ǹ�
            Destroy(gameObject);  
        }

        // �浹 ����
        Vector3 p1 = transform.position;  // ȭ���� �߽� ��ǥ. ��, ȭ���� ��ġ
        Vector3 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ. ��, �÷��̾��� ��ġ
        // �Ÿ�(����)�� ���ϴ� ��� 1
        float d = Vector3.Distance(p2, p1);
        /* �Ÿ�(����)�� ���ϴ� ��� 2
        float d = (p2 - p1).magnitude; */
        /* �Ÿ�(����)�� ���ϴ� ��� 3
        Vector2 dir = p2 - p1;  // p1 - p2
        float d = dir.magnitude; */
        if (d < this.radius + player.radius)
        {
            // ���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� �����Ѵ�
            //GameObject director = GameObject.Find("GameDirector");
            //director.GetComponent<GameDirector>().DecreaseHp();

            this.player.hp -= 1;
            this.gameDirector.UpdateHpGauge(this.player.hp, this.player.maxHp);

            // �浹�� ��� ���� ������Ʈ�� ȭ���� �Ҹ��Ų��
            Destroy(gameObject);
        }

        // �浹 ���� ����뿡 ����
        // ������ ���� ��ġ�� ���� ��ġ ���̿� ��
        Debug.DrawLine(p1, p2, Color.red);
    }

    // �浹 ���� ����뿡 ����
    // ��ü �����
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}
