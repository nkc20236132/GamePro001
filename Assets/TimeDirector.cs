using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDirector : MonoBehaviour
{
    GameObject timeGauge;
    float delta = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.timeGauge = GameObject.Find("timeGauge");
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        delta += 1;
        if (this.delta == 6)
        {
            this.delta = 0;
            //�P�b��timeGauge���O�D�O�P���炷
            this.timeGauge.GetComponent<Image>().fillAmount -= 0.001f;
        }

        //�Q�[�W���O�ɂȂ�����^�C�g��
        if (this.timeGauge.GetComponent <Image>().fillAmount == 0 ) 
        {
            SceneManager.LoadScene("TitleScene");
        }
        
    }
}
