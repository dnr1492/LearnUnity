using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 1;
    float delta = 0;  // ��� �ð� �ʱⰪ

<<<<<<< HEAD
    private GameDirector gameDirector;

    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
=======
    void Start()
    {
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
    }

    void Update()
    {
<<<<<<< HEAD
        if(this.gameDirector.isGameOver) return;

        // �� �����Ӹ��� ��� �ð��� ����
        this.delta += Time.deltaTime;  
        // ���� ��� �ð��� 1���̻��̶��
        if (this.delta >= this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate<GameObject>(arrowPrefab);
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);  // x�� -8.7 ~ 7.7 ����
=======
        this.delta += Time.deltaTime;  // �� �����Ӹ��� ��� �ð��� ����
        if (this.delta >= this.span)
        {
            this.delta = 0;
            //GameObject go = Instantiate(arrowPrefab) as GameObject;  // ������ �ν��Ͻ�ȭ. ��, �������� �������� ���� ��� 1
            GameObject go = Instantiate<GameObject>(arrowPrefab);  // ������ �ν��Ͻ�ȭ. ��, �������� �������� ���� ��� 2
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
        }
    }
}
