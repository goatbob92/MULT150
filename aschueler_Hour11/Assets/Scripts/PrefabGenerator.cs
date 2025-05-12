using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Vector3 position = prefab.transform.position;
        for (int i = 0; i < 10; i++)
        {
            position.x += 2;
            Instantiate(prefab, position, transform.rotation);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
