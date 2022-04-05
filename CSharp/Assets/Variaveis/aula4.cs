using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula4 : MonoBehaviour
{

    int n1, n2;

    void Start()
    {
        n1 = 40;
        n2 = 32;
        Soma();
        multiplicação(n1, n2);
    }

    
    void Update()
    {
        
    }


    void Soma()
    {
        int resultado;
        resultado = n1 + n2;
        Debug.Log(resultado);
    }

    void multiplicação(int valA, int valB)
    {
        int resultado;
        resultado = valA * valB;
        Debug.Log(resultado);
    }

}
