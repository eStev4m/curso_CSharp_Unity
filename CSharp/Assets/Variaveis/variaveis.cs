using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    int vidaPlayer = 10, atackEnemy = 5;
    float jumpForce = 5.5f;
    bool mortePlayer = false;
    string nomePlayer = "Estevam";


    void Start()
    {
        string nomeEnemy;
        print(vidaPlayer);
        nomePlayer = "Jannuzzi";
        nomeEnemy = "Poodle";
    }

    
    void Update()
    {
        nomePlayer = "Ribeiro";
    }
}
