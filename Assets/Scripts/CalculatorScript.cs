using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField1;
    [SerializeField] private TMP_InputField inputField2;
    [SerializeField] private TMP_Text resultText;
    public void OnClickPlus()
    {
        if (TryGetNumbers(out int num1, out int num2))
        {
            float result = num1 + num2;
            resultText.text = result.ToString(); 
        }
    }

    public void OnClickMinus()
    {
        if(TryGetNumbers(out int num1, out int num2))
        {
            float result = num1 - num2;
            resultText.text = result.ToString();
        }
    }

    private bool TryGetNumbers(out int num1, out int num2) {
        num1 = 0;
        num2 = 0;
        bool success = true;
        if (int.TryParse(inputField1.text, out int num_1)) {
            num1 = num_1;
        } else {
            success = false;
        }
        if (int.TryParse(inputField2.text, out int num_2)) {
            num2 = num_2;
        } else {
            success = false;
        }
        if (success == false) resultText.text = "Введите правильные числа!";
        return success;
    }
    public void OnClickMultiplication()
    {
        if(TryGetNumbers(out int num1, out int num2))
        {
            float result = num1 * num2;
            resultText.text = result.ToString();
        }
    }
    public void OnClickDivision()
    {
        if(TryGetNumbers(out int num1, out int num2))
        {
            float result = num1 / num2;
            resultText.text = result.ToString();
        }
    }
}