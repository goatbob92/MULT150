using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosBallScript : MonoBehaviour
{
    float timeElapsed = 0f;
   public GameObject floor;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= 3)
        {
            Color chaosColor = new Color (Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
            floor.GetComponent<Renderer>().material.color = chaosColor;
            foreach(GameObject chaos in GameObject.FindGameObjectsWithTag("Chaos"))
            {
                if(chaos.GetComponent<Rigidbody>() != null)
                {
                    chaos.GetComponent<Rigidbody>().velocity = new Vector3 (Random.Range(10, 55), 0, Random.Range(20, 55));
                    chaos.GetComponent<Renderer>().material.color = chaosColor;
                }
                else{
                    chaos.GetComponent<Light>().color = chaosColor;
                }
                    
            }
            timeElapsed %= 1;
        }
    }
}
