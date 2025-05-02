using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int chaosCount = 0;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if(collidedWith.tag == gameObject.tag && collidedWith.tag != "Chaos")
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy (collidedWith);
        }
        else if(collidedWith.tag == gameObject.tag)
        {
            if(chaosCount <= 3){
                chaosCount += 1;
                Destroy (collidedWith);
            }
            else if (chaosCount >= 4){
                isSolved = true;
                GetComponent<Light>().enabled = false;
                Destroy (collidedWith);
            }
        }
    }
}
