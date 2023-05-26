using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {

        //下キーを押したとき下に傾くアニメーション
        if(Input.GetKey(KeyCode.DownArrow)) 
        {
                this.animator.SetTrigger("RightTrigger");
        }
        //上キーを押したとき上に傾くアニメーション
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.animator.SetTrigger("LeftTrigger");
        }
        else
        {
            this.animator.SetTrigger("NormalTrigger");
        }
    }
}
