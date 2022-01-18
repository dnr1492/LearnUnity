using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 1;
    float delta = 0;  // 경과 시간 초기값

    private GameDirector gameDirector;

    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }

    void Update()
    {
        if(this.gameDirector.isGameOver) return;

        // 매 프레임마다 경과 시간을 누적
        this.delta += Time.deltaTime;  
        // 만약 경과 시간이 1초이상이라면
        if (this.delta >= this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate<GameObject>(arrowPrefab);
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);  // x축 -8.7 ~ 7.7 사이
        }
    }
}
