using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCotroller : MonoBehaviour
{
    //[SerializeField]でprivateでインスペクターからいじれるようにする
    //ジャンプ力を設定
    [SerializeField] float jumpForce = 1.0f;
    //Rigidbodyを取得
    [SerializeField] Rigidbody2D rb;
     [SerializeField]Animator animator;

    bool isJump = false;

    void Start()
    {
        //rigidbodyを取得
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //スコアを0に直す
        ScoreManager.score = 0;
    }

    void Update()
    {
        //Spaceか左クリックされたらジャンプ
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    //固定フレーム更新
    void FixedUpdate()
    {
        //速度がマイナスになったら
        if(rb.velocity.y < 0)
        {
            isJump = false;
        }
        //現在のポジションを取得
        Vector2 pos = transform.position;
        //画面外に出ないようにする
        float y = transform.position.y;
        float vx = rb.velocity.x;
        if (y > Waku.TopPos) {
          rb.velocity = Vector2.zero; // 速度を一度リセットする
          pos.y = Waku.TopPos; // 押し戻しする
        }
        if (y < Waku.BottomPos) {
          // 下に落ちたらオートジャンプ
          rb.velocity = Vector2.zero; // 落下速度を一度リセットする
          rb.AddForce(new Vector2(0, jumpForce));
          pos.y = Waku.BottomPos; // 押し戻しする
        }
        //位置を更新
        transform.position = pos;
        //animatorのパラメーターの設定
        animator.SetBool("IsJump", isJump);
    }

    void Jump()
    {
        //ジャンプしている
        isJump = true;
        rb.velocity = Vector2.zero; //落下速度を一度0にする
        rb.AddForce(Vector2.up * jumpForce);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Time.deltatimeとFixedUpdateが停止する
        //Time.timeScale = 0;
        SceneManager.LoadScene("Result",LoadSceneMode.Single);
    }
}

