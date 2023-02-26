using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountBird : MonoBehaviour
{

    // �ŏ��l��\��
    public TextMeshProUGUI birdcount;

    //�ő�l�̕ύX
    public int Bird;

    public void Start()
    {
        Bird = 9;

        UpdateLabel();
    }

    public void OnClickMinus()
    {
        if(Bird > 3 )
        {
            Bird--;
        }

        UpdateLabel();
    }

    public void OnClickPlus()
    {
        if (Bird < 9)
        {
            Bird++;
        }

        UpdateLabel();
    }

    void UpdateLabel()
    {
        string BirdStr = Bird.ToString();
        birdcount.text = BirdStr;
    }
}


