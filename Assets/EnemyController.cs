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
     //�P�t���[���ŗ���
     transform.Translate(-0.1f, 0, 0);
        
    //��ʊO�ŃI�u�W�F�N�g��j��
    if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1- p2;
        float d = dir.magnitude;
        //�G�̔��a
        float r1 = 0.5f;
        //�v���C���[�̔��a
        float r2 = 1.0f;

        //�ڐG������j��
        if(d < r1 + r2)
        {
            Destroy (gameObject);
        }
    }
}
