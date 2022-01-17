using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // ���� ������ Ȱ���Ͽ� ���� �Ǵ� ���������� ȸ��
    public enum eDir
    {
        Left = 1, Right = -1
    }
    public eDir dir;

    float rotSpeed = 0;  // ���콺�� Ŭ���ϱ� �� ȸ�� �ӵ� : 0
    public int initRotate = 10;   // ȸ�� �ӵ�

    public float atten = 0.96f;  // ���� ���

    void Start()
    {
    }

    void Update()
    {
        // ���� ���콺�� Ŭ���ϸ� ȸ�� �ӵ��� ȸ�� ������ ����
        // ���콺�� Ŭ���� �� ȸ�� �ӵ� : 10 �Ǵ� -10 �Ǵ� initRotate * (int)dir
        if (Input.GetMouseButtonDown(0))
        {
            //this.rotSpeed = 10;  // �������� ȸ��
            //this.rotSpeed = -10;  // ���������� ȸ��
            //this.rotSpeed = 10 * (int)dir;  // ���� ������ Ȱ���Ͽ� ���� �Ǵ� ���������� ȸ��
            this.rotSpeed = initRotate * (int)dir;
        }

        // �� �����Ӹ��� ȸ�� �ӵ���ŭ �귿�� ȸ��
        transform.Rotate(0, 0, this.rotSpeed);

        // ȸ�� �ӵ��� ���ӽ�Ű��
        //this.rotSpeed *= 0.96f;
        this.rotSpeed *= atten;
    }
}
