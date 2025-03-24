using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
