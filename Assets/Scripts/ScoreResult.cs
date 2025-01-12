using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using unityroom.Api;

public class ScoreResult : MonoBehaviour
{
    public Text score;
    public Text Maxscore;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score    :" + ScoreManager.score.ToString();
        // ボードNo1にスコアを送信する。
        UnityroomApiClient.Instance.SendScore(1, ScoreManager.Maxscore, ScoreboardWriteMode.Always);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
