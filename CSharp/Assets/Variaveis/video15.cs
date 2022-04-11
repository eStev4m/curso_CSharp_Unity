using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video15 : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        for (int x=0; x<10; x=x+1)
        {
            if(x==5)
            {
                continue;
            }
            Debug.Log(x);
        }


    }

}
