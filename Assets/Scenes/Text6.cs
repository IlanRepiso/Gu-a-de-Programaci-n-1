using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text6 : MonoBehaviour
{
    /*Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter %.*/

    public int num1 = 1;

    // Start is called before the first frame update
    void Start()
    {
        int resultado;
        resultado = num1 % 2;

        if (resultado == 1)
        {
            Debug.Log("el número es impar");
        }
        else
        {
            Debug.Log("el número es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
