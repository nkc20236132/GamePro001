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
            //ÇPïbÇ≈timeGaugeÇÇOÅDÇOÇPå∏ÇÁÇ∑
            this.timeGauge.GetComponent<Image>().fillAmount -= 0.001f;
        }

        //ÉQÅ[ÉWÇ™ÇOÇ…Ç»Ç¡ÇΩÇÁÉ^ÉCÉgÉã
        if (this.timeGauge.GetComponent <Image>().fillAmount == 0 ) 
        {
            SceneManager.LoadScene("TitleScene");
        }
        
    }
}
