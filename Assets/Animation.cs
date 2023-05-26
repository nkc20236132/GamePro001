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

        //���L�[���������Ƃ����ɌX���A�j���[�V����
        if(Input.GetKey(KeyCode.DownArrow)) 
        {
                this.animator.SetTrigger("RightTrigger");
        }
        //��L�[���������Ƃ���ɌX���A�j���[�V����
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
