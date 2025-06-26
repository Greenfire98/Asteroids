using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorDemo : MonoBehaviour
{
    public float number1;
    public float number2;
    public float Screen;

    // Start is called before the first frame update
    void Start()
    {
        float number1 = 10f;
        float number2 = 30f;
        float result = Add(number1, number2);
        Debug.Log(result);

        //CrashUnity();

    }

    // Update is called once per frame
    void Update()
    {
        // When the plus button is pressed execute addition
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Screen = Add(number1, number2);
        }
        
        // When the minus button is pressed execute subtraction
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            Screen = Subtract(number1, number2);
        }

        // When the asterix button is pressed execute multiplication
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            Screen = Multiply(number1, number2);
        }

        // When the plus button is pressed execute addition
        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            Screen = Divide(number1, number2);
        }
    }


// Addition
public float Add(float number1, float number2)
{
    float result = number1 + number2;
    return result;

}

// Subtraction
public float Subtract(float number1, float number2)
{
    float result = number1 - number2;
    return result;

}

// Multiplication
public float Multiply(float number1, float number2)
{
    float result = number1 * number2;
    return result;

}

// Division
public float Divide(float number1, float number2)
{
    float result = number1 / number2;
    return result;

}

}
