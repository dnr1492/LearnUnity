using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float radius = 1.0f;  // 플레이어의 반경(반지름), 반지름을 수정하여 충돌 범위를 변경 가능

    private GameDirector gameDirector;
    public float maxHp;
    public float hp;

    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
        this.hp = this.maxHp;
    }

    void Update()
    {
        if (this.gameDirector.isGameOver) return;

        // 키보드 왼쪽 화살표를 누르면
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);  // x축 왼쪽으로 3 움직인다
        }

        // 키보드 오른쪽 화살표를 누르면
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);  // x축 오른쪽으로 3 움직인다
        }

        // 플레이어가 화면 밖으로 못 나가게 하는 방법 1
        // 카메라의 좌측 하단은 (0,0 , 0.0) 이며, 우측 상단은 (1.0 , 1.0)
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.05f) pos.x = 0.05f;
        if (pos.x > 0.95f) pos.x = 0.95f;
        //if (pos.y < 0.1f) pos.y = 0.1f;
        //if (pos.y > 0.9f) pos.y = 0.9f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    // 왼쪽 UI 화살표를 클릭하면
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);  // x축 왼쪽으로 1 움직인다

        // 플레이어가 화면 밖으로 못 나가게 하는 방법 2
        //if (this.transform.position.x <= -7.82f)
        //{
        //    var pos = this.transform.position;
        //    pos.x = -7.82f;
        //    this.transform.position = pos;
        //}
    }

    // 오른쪽 UI 화살표를 클릭하면
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);  // x축 오른쪽으로 1 움직인다

        // 플레이어가 화면 밖으로 못 나가게 하는 방법 2
        //if (this.transform.position.x >= 7.77f)
        //{
        //    var pos = this.transform.position;
        //    pos.x = 7.77f;
        //    this.transform.position = pos;
        //}
    }

    // 충돌 판정 디버깅에 도움
    // 구체 기즈모
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}
