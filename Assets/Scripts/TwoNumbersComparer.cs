using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField1;
    [SerializeField] private TMP_InputField InputField2;
    [SerializeField] private TMP_Text Total;

    public void Compare()
    {
        string text1 = InputField1.text;
        string text2 = InputField2.text;
        if (float.TryParse(text1, out float number1) && float.TryParse(text2, out float number2)) {
            if (number1 > number2)
            {
                Total.text = "Наибольшее число -" + number1;
            }
            else if (number1 < number2)
            {
                Total.text = "Наибольшее число -" + number2;
            }
            else if (number1 == number2)
            {
                Total.text = "Равны";
            }
            else
            {
                Total.text = "Введите корректные числа!";
            }
        }
    }
}