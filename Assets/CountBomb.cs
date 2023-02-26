    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountBomb : MonoBehaviour
{

    // �ŏ��l��\��
    public TextMeshProUGUI bombcount;

    //�ő�l�̕ύX
    private int Bomb;

    public CountBird countbird;

    public void Start()
    {
        Bomb = 3;

        UpdateLabel();
    }

    public void OnClickMinus()
    {

        if (Bomb > 1)
        {
            Bomb--;
        }

        UpdateLabel();
    }

    public void OnClickPlus()
    {
        if (Bomb < 3)
        {
            Bomb++;
        }
       

        UpdateLabel();
    }

    void UpdateLabel()
    {
        string BombStr = Bomb.ToString();
        bombcount.text = BombStr;
    }



}

