using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KmDirector : MonoBehaviour
{
    Text textComponent;
    int score = 0;



    void Start()
    {
        textComponent = GetComponent<Text>();

    }

    void Update()
    {
        //1�b�łU�O����Score�𑝂₷
        string a = textComponent.text;
        score++;
        a = score.ToString("D6");
        textComponent.text = a;
    }
}
