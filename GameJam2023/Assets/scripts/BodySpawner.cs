using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpawner : MonoBehaviour
{
    public GameObject deadPlayer; 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(deadPlayer, transform.position, Quaternion.identity);
        }
    }
}
