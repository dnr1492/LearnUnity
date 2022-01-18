using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //GameObject player;
    private PlayerController player;
    public float radius = 0.5f;  // 화살의 반경(반지름), 반지름을 수정하여 충돌 범위를 변경 가능

    private GameDirector gameDirector;

    void Start()
    {
        //this.player = GameObject.Find("player");
        this.player = GameObject.FindObjectOfType<PlayerController>();

        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }

    void Update()
    {
        // 매 프레임마다 등속으로 낙하 (-y축이므로 아래로)
        transform.Translate(0, -0.1f, 0);
        //transform.Translate(0, 0.1f, 0);  // 매 프레임마다 등속으로 상승 (+y축이므로 위로)

        // 화면 밖으로 나가면 게임 오브젝트인 화살을 소멸시킨다
        if (transform.position.y < -3.99f)
        {
            if (!this.gameDirector.isGameOver)
            {
                this.gameDirector.IncreaseScore(10);
            }

            // 스크립트가 화살에 있으므로 여기서 gameObject 는 화살을 의미
            Destroy(gameObject);  
        }

        // 충돌 판정
        Vector3 p1 = transform.position;  // 화살의 중심 좌표. 즉, 화살의 위치
        Vector3 p2 = this.player.transform.position;  // 플레이어의 중심 좌표. 즉, 플레이어의 위치
        // 거리(길이)를 구하는 방법 1
        float d = Vector3.Distance(p2, p1);
        /* 거리(길이)를 구하는 방법 2
        float d = (p2 - p1).magnitude; */
        /* 거리(길이)를 구하는 방법 3
        Vector2 dir = p2 - p1;  // p1 - p2
        float d = dir.magnitude; */
        if (d < this.radius + player.radius)
        {
            // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다
            //GameObject director = GameObject.Find("GameDirector");
            //director.GetComponent<GameDirector>().DecreaseHp();

            this.player.hp -= 1;
            this.gameDirector.UpdateHpGauge(this.player.hp, this.player.maxHp);

            // 충돌한 경우 게임 오브젝트인 화살을 소멸시킨다
            Destroy(gameObject);
        }

        // 충돌 판정 디버깅에 도움
        // 지정된 시작 위치와 종료 위치 사이에 선
        Debug.DrawLine(p1, p2, Color.red);
    }

    // 충돌 판정 디버깅에 도움
    // 구체 기즈모
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}
