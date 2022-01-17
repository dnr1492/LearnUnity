using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnVector : MonoBehaviour
{
    void Start()
    {
        // ���� ����
        Vector2 startPos = new Vector2(2.0f, 1.0f);  // x�� �������� 2 �� y�� �������� 1 ��ŭ �������ٴ� ���� �ǹ�
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;  // ���� ���� : ���� (�����)
        //Vector2 dir = startPos - endPos  // ���� ���� : ���� (������)  
        float distance = dir.magnitude;  // ���� ���� + magnitude : ����

        // ���� ����
        Vector2 playerPos = new Vector2(2, 3);
        playerPos += new Vector2(8, 5);
        Debug.Log(playerPos);

        // ���� ���� (�Ӽ�)
        Vector2 Pos = new Vector2(2, 3);
        Pos.x += 8;
        Pos.y += 5;
        Debug.Log(Pos);
    }

    void Update()
    {

    }
}
