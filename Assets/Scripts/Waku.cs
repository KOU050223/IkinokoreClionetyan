using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waku : MonoBehaviour
{
    public static float TopPos;
    public static float BottomPos;
    public static float RightPos;
    public static float LeftPos;

    // Start is called before the first frame update
    void Start()
    {
        TopPos = GetTop();
        BottomPos = GetBottom();
        RightPos = GetRight();
        LeftPos = GetLeft();
    }

    //画面上部を取得
    float GetTop()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        return max.y;
    }
    //画面下を取得
    float GetBottom()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.y;
    }
    //画面右を取得
    float GetRight()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        return max.x;
    }
    //画面下を取得
    float GetLeft()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.x;
    }

}
