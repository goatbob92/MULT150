using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        // opposite because we rotate about those axes
        transform.Rotate(dirY, -dirX, 0);
        CheckForRaycastHit();

        void CheckForRaycastHit()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name + " destroyed!");
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
