using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {

            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                        if(Input.GetKeyDown(KeyCode.F))
                        {   
                            if(hit.collider.gameObject.tag == "Door")
                            {
                                if(hit.collider.gameObject.GetComponent<DoorBase>())
                                {
                                    gameManager.GetComponent<GameManager>().StartRun();
                                }
                                hit.collider.gameObject.GetComponent<Door>().ChangeDoorState();
                            }
                            }
                        if(Input.GetKey(KeyCode.F))
                        {   
                            if(hit.collider.gameObject.tag == "Papper")
                            {
                                hit.collider.gameObject.GetComponent<ThePapper>().ShowPapper();
                            }
                        }
            }
    }
}
