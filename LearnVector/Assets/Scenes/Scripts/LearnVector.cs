using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnVector : MonoBehaviour
{
    void Start()
    {
        // ∫§≈Õ ª¨º¿
        Vector2 startPos = new Vector2(2.0f, 1.0f);  // x√‡ πÊ«‚¿∏∑Œ 2 π◊ y√‡ πÊ«‚¿∏∑Œ 1 ∏∏≈≠ øÚ¡˜ø¥¥Ÿ¥¬ ∞Õ¿ª ¿«πÃ
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;  // ∫§≈Õ ª¨º¿ : πÊ«‚ (øÏªÛ«‚)
        //Vector2 dir = startPos - endPos  // ∫§≈Õ ª¨º¿ : πÊ«‚ (øÏ«œ«‚)  
        float distance = dir.magnitude;  // πÊ«‚ ∫§≈Õ + magnitude : ±Ê¿Ã

        // ∫§≈Õ µ°º¿
        Vector2 playerPos = new Vector2(2, 3);
        playerPos += new Vector2(8, 5);
        Debug.Log(playerPos);

        // ∫§≈Õ µ°º¿ (º”º∫)
        Vector2 Pos = new Vector2(2, 3);
        Pos.x += 8;
        Pos.y += 5;
        Debug.Log(Pos);
    }

    void Update()
    {

    }
}
