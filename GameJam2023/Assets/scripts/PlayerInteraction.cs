using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    // public float interactionDistance;
    // public TMPro.TextMeshProUGUI interactionText;
    // Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam = GetComponent<Camera>;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width/2f, Screem.height/2f,0f));
        RaycastHit hit;

        bool successfulHit = false;


        if(Physics.Raycast(ray,out hit, interactionDistance)){
            if(intractable != null){
                HandelInteraction(interaction);
                interactionText.text = interactable.GetDescription();
                successfulHit = true;
            }
        }

        if(!successfulHit) interaction.text = "";
        */
    }
    // void HandelInteraction(Interactable interactable){
    //     KeyCode key = KeyCode.F;
    //     switch(interactable.InteractionType){
    //         case Interactable.InteractionType.CLick:
    //          if(Input.GetKEyDown(key)){
    //             interactable.interact();
    //          }
    //          break;
    //          default:
    //          throw new System.Exception("Katki");
    //     }
        
    // }
}
