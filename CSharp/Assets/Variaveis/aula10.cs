using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula10 : MonoBehaviour
{

    int moedas = 50, preçoPersonagem = 100;

    // Start is called before the first frame update
    void Start()
    {
        if(moedas > preçoPersonagem)
        {
            print("Posso comprar personagem?");
        }
        else if(moedas == preçoPersonagem)
        {
            print("Posso comprar o personagem porém fico sem moedas!");
        }
        else
        {
            print("Moedas insulficientes!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
