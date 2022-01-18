using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
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
    }

    // UI ���� ȭ��ǥ�� Ŭ���ϸ�
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);  // x�� �������� 1 �����δ�
    }

    // UI ������ ȭ��ǥ�� Ŭ���ϸ�
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);  // x�� ���������� 1 �����δ�
    }
}
