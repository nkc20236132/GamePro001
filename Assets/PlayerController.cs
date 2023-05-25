using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        // �ړ�
        // ���ݒn�@�{���@�ړ������@���@�ړ��ʁ@���@�P�t���[�����������鎞��
        // ���ݒn�@transform.position
        // �ړ������@Vector3 �̕ϐ���p��
        // �ړ��ʁ@�@float �̕ϐ���p��
        // �P�t���[�����������鎞��(1/60) Time.deltaTime



        Vector3 dir = Vector3.zero; // �ړ�������ۑ�����ϐ�
        float speed = 10;            // �ړ��ʂ�ۑ�����ϐ�



        // �J�[�\���L�[�̏����ړ������ɔ��f
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        //����
        int muki = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            muki = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            muki = -1;
        }


        if (muki != 0)
        {
            transform.localScale = new Vector3(1, muki, 1);
        }


        // speed m/s �̑��x�ŃI�u�W�F�N�g���ړ�������
        transform.position += dir.normalized * speed * Time.deltaTime;






    }
}
