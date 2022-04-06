using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula9 : MonoBehaviour
{

    string humor;
    bool pizza, refrigerante;


    // Start is called before the first frame update
    void Start()
    {
        pizza = true;
        refrigerante = false;
        humor = (pizza == true) || (refrigerante == true) ? "Feliz" : "Triste";
        Debug.Log(humor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
