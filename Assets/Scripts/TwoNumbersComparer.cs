using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField InputField1;
    [SerializeField] private InputField InputField2;
    [SerializeField] private Text Total;

    public void Compare()
    {
        if(string.IsNullOrEmpty(InputField1.text) || string.IsNullOrEmpty(InputField2.text)) {
            Total.text = "Введите корректные числа!";
            return;
        }
    }
}

