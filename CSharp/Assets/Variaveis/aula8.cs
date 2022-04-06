using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula8 : MonoBehaviour
{

    int num1 = 10, num2 = 20;
    string resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 >= num2 ? "Sim" : "Não";
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
