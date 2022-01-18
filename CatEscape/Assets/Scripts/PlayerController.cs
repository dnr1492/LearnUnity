using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
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
    }

    // UI 왼쪽 화살표를 클릭하면
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);  // x축 왼쪽으로 1 움직인다
    }

    // UI 오른쪽 화살표를 클릭하면
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);  // x축 오른쪽으로 1 움직인다
    }
}
