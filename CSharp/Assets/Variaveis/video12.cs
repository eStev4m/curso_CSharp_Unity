using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video12 : MonoBehaviour
{

    // Criar um método que dado um número, retorne se ele é ìmpar, par ou nulo

    // Operador aritmético % (retorna o resto de uma divisão inteira)
    string txt2;
    void Start()
    {
        txt2 = impar_par(6);
        Debug.Log(txt2);
    }

    string impar_par(int numero)
    {
        string txt;
        if(numero==0)
        {
            txt = "O numero é nulo";
        }
        else
        {
            int resto = numero % 2;
            if(resto==0)
            {
                txt = "O numero é par";
            }
            else
            {
                txt = "O numero é ímpar";
            }
        }
        return txt;
    }
    string impar_par2(int numero)
    {
        string txt;
        switch (numero)
        {
            case 0:
                txt = "O numero é nulo";
                break;
            default:
                int resto = numero % 2;
                switch(resto)
                {
                    case 0:
                        txt = "O numero é par";
                        break;
                    default:
                        txt = "O numero é ímpar";
                        break;
                }
                break;
        }
        return txt;
    }

}
