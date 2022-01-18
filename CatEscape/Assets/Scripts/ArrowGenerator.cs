using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 1;
    float delta = 0;  // 경과 시간 초기값

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

        // 매 프레임마다 경과 시간을 누적
        this.delta += Time.deltaTime;  
        // 만약 경과 시간이 1초이상이라면
        if (this.delta >= this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate<GameObject>(arrowPrefab);
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);  // x축 -8.7 ~ 7.7 사이
=======
        this.delta += Time.deltaTime;  // 매 프레임마다 경과 시간을 누적
        if (this.delta >= this.span)
        {
            this.delta = 0;
            //GameObject go = Instantiate(arrowPrefab) as GameObject;  // 프리팹 인스턴스화. 즉, 프리팹을 동적으로 생성 방법 1
            GameObject go = Instantiate<GameObject>(arrowPrefab);  // 프리팹 인스턴스화. 즉, 프리팹을 동적으로 생성 방법 2
            float px = Random.Range(-8.7f, 8.7f);
            go.transform.position = new Vector3(px, 4.44f, 0);
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
        }
    }
}
