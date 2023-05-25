using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
     //１フレームで落下
     transform.Translate(-0.1f, 0, 0);
        
    //画面外でオブジェクトを破壊
    if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1- p2;
        float d = dir.magnitude;
        //敵の半径
        float r1 = 0.5f;
        //プレイヤーの半径
        float r2 = 1.0f;

        //接触したら破壊
        if(d < r1 + r2)
        {
            Destroy (gameObject);
        }
    }
}
