using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    [SerializeField] int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        count++;
        Debug.Log("Bounces: " + count);
    }
}
