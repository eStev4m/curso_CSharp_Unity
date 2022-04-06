using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula7 : MonoBehaviour
{
    int numero1 = 10, numero2 = 20;
    string nome1 = "Urso", nome2 = "Poodle";
    bool win = true, lose = false;

    // Start is called before the first frame update
    void Start()
    {
        print(numero1 > numero2);
        print(numero1 < numero2);
        print(nome1 != nome2);
        print(win == false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
