using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start is called before the first frame update
    public Transform cam;
    public float playerActivatedDistance;
    public Transform Button;
    public Door door;
    bool active = false;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivatedDistance);
        if(Input.GetKeyDown(KeyCode.F)){
                if(hit.transform == Button){
                    door.ActivateDoor();
                }
            
        }
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
