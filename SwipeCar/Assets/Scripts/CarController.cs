using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;  // ������ ������ ���� �ӵ��� 0 �̹Ƿ� �ڵ����� �������� �ʴ´�

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))  // ���� ���콺�� Ŭ���ϸ�
        //{
        //    this.speed = 0.2f;  // �ʱ� �ӵ� ����
        //}

        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 ���� ��ư�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ���� ��ư�� ������ �� ��ǥ
            endPos = Input.mousePosition;
            // ��������(�巹��) ���� ���ϱ�
            float swipeLength = this.endPos.x - this.startPos.y;
            // ��������(�巹��) ���̸� �ʱ� �ӵ��� ����
            this.speed = swipeLength / 5000.0f;
        }

        transform.Translate(this.speed, 0, 0);  // x������ �̵�
        this.speed *= 0.98f;  // ����
    }
}
