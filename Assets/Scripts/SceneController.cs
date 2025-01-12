using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SwitchScene(String NextScene)
    {
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        //スコアを0に直す
        //ScoreManager.score = 0;
        //PlayerControllerのStart()に上の文を移動しました。
        //Time.timeScale = 1;

    }
}
