using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
    
        print(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the " + gameObject.name);
    }
}
