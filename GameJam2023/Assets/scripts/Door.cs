using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform target;
    public float speed;
    private bool activate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activate){
            float step = speed *Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,target.position,step);
        }
    }
    public void ActivateDoor(){
        activate=true;
    }

}
