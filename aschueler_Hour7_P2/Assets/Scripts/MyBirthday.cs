using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1; i<=31; i++)
        {
            if(i == 9)
                Debug.Log("It's my birthday!");
            else
                 Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
