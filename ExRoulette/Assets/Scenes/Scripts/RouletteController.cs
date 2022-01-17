using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // 열거 형식을 활용하여 왼쪽 또는 오른쪽으로 회전
    public enum eDir
    {
        Left = 1, Right = -1
    }
    public eDir dir;

    float rotSpeed = 0;  // 마우스를 클릭하기 전 회전 속도 : 0
    public int initRotate = 10;   // 회전 속도

    public float atten = 0.96f;  // 감쇠 계수

    void Start()
    {
    }

    void Update()
    {
        // 왼쪽 마우스를 클릭하면 회전 속도와 회전 방향을 설정
        // 마우스를 클릭한 후 회전 속도 : 10 또는 -10 또는 initRotate * (int)dir
        if (Input.GetMouseButtonDown(0))
        {
            //this.rotSpeed = 10;  // 왼쪽으로 회전
            //this.rotSpeed = -10;  // 오른쪽으로 회전
            //this.rotSpeed = 10 * (int)dir;  // 열거 형식을 활용하여 왼쪽 또는 오른쪽으로 회전
            this.rotSpeed = initRotate * (int)dir;
        }

        // 매 프레임마다 회전 속도만큼 룰렛을 회전
        transform.Rotate(0, 0, this.rotSpeed);

        // 회전 속도를 감속시키기
        //this.rotSpeed *= 0.96f;
        this.rotSpeed *= atten;
    }
}
