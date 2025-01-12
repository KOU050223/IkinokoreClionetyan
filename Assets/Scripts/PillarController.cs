using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    [SerializeField] float PillarSpeed = 6.0f;
    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //現在のポジションを取得
        Vector2 pos = transform.position;
        //画面の左端から-1.0f進んだら削除
        if(pos.x < Waku.LeftPos - 1.0f)
        {
            Destroy(this.gameObject);
        }

        //プレイヤーの位置(-6.2fくらい)を超えたらスコア加算
        if(pos.x < -6.2f && flag == false)
        {
            flag =true;
            ScoreManager.score += 1;
            //Debug.Log("加点");
        }
    }

    void FixedUpdate()
    {
        //現在のポジションを取得
        Vector2 pos = transform.position;
        //ポジションを変更
        pos.x -= Time.deltaTime * PillarSpeed;
        //位置更新
        transform.position = pos;
    }
}
