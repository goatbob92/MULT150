using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal") / 400f;
        float vert = Input.GetAxis("Vertical") / 400f;
        transform.Translate(horiz, vert, 0);
    }
}
