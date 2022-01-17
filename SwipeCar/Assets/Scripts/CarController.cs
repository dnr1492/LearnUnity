using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;  // 게임이 시작할 때는 속도가 0 이므로 자동차가 움직이지 않는다

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))  // 왼쪽 마우스를 클릭하면
        //{
        //    this.speed = 0.2f;  // 초기 속도 설정
        //}

        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 왼쪽 버튼을 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 왼쪽 버튼을 떼었을 때 좌표
            endPos = Input.mousePosition;
            // 스와이프(드레그) 길이 구하기
            float swipeLength = this.endPos.x - this.startPos.y;
            // 스와이프(드레그) 길이를 초기 속도로 변경
            this.speed = swipeLength / 5000.0f;
        }

        transform.Translate(this.speed, 0, 0);  // x축으로 이동
        this.speed *= 0.98f;  // 감속
    }
}
