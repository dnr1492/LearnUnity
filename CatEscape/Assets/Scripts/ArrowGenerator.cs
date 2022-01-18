using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 1;
    float delta = 0;  // ��� �ð� �ʱⰪ

    void Start()
    {
    }

    void Update()
    {
        this.delta += Time.deltaTime;  // �� �����Ӹ��� ��� �ð��� ����
        if (this.delta >= this.span)
        {
            this.delta = 0;
            //GameObject go = Instantiate(arrowPrefab) as GameObject;  // ������ �ν��Ͻ�ȭ. ��, �������� �������� ���� ��� 1
            GameObject go = Instantiate<GameObject>(arrowPrefab);  // ������ �ν��Ͻ�ȭ. ��, �������� �������� ���� ��� 2
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);
        }
    }
}
