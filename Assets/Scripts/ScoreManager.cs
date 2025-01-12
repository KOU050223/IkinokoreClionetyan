using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public string score_switch;
    public static int score = 0;
    public static int Maxscore = 0;

    void Start()
    {
        
    }

    void Update()
    {     
        //オブジェクトからTextコンポーネントを取得
        Text score_text =score_object.GetComponent<Text>();
        score_text.text = score.ToString();
        //最高点の更新
        if(score > Maxscore)
        {
            Maxscore = score;
        }
    }
}
