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
        // 매 프레임마다 등속으로 낙하 (y축이므로 아래로)
        transform.Translate(0, -0.1f, 0);
        //transform.Translate(0, 0.1f, 0);  // 매 프레임마다 등속으로 상승 (y축이므로 위로)

        // 화면 밖으로 나오면 게임 오브젝트인 화살표를 소멸시킨다
        if (transform.position.y < -3.99f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;  // 화살의 중심 좌표. 즉, 화살의 위치
        Vector2 p2 = this.player.transform.position;  // 플레이어의 중심 좌표. 즉, 플레이어의 위치
        Vector2.Distance(p2, p1);
        Vector2 dir = p2 - p1;  // p1 - p2
        float d = dir.magnitude;
        float r1 = 0.5f;  // 화살의 반경(반지름)
        float r2 = 1.0f;  // 플레이어의 반경(반지름)
        if (d < r1 + r2)
        {
            // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            // 충돌한 경우 게임 오브젝트인 화살표를 소멸시킨다
            Destroy(gameObject);
        }

    }
}
