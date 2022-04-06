using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula6 : MonoBehaviour
{
    int numero;
    float tempo;

    void Start()
    {
        
    }

    
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        Debug.Log(tempo);
    }
}
