using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video14 : MonoBehaviour
{

    int x=1;

    // Start is called before the first frame update
    void Start()
    {
        /*while (x<11)
        {
            Debug.Log(x);
            x += 1;
        }*/

        do
        {
            Debug.Log(x);
            x += 1;
        } while (x<11);
    }

}
