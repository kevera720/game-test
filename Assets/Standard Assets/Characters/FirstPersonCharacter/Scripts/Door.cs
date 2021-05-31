using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float dooropenAngle = 0f;
    public float doorcloseAngle = 0f;
    
    private Quaternion OpenDoor = Quaternion.identity;
    private Quaternion CloseDoor = Quaternion.identity;

    public AudioSource audio;
    public AudioClip closeDoor;
    public AudioClip openDoor;

    public bool open;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void ChangeDoorState()
    {
        open = !open;
        if(open)
        {
            audio.PlayOneShot(openDoor, 1f);
        }
        else
        {
         audio.PlayOneShot(closeDoor, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor = Quaternion.Euler(transform.rotation.x, dooropenAngle, transform.rotation.z);
        CloseDoor = Quaternion.Euler(transform.rotation.x, doorcloseAngle, transform.rotation.z);
        if(open)
        {
             transform.rotation = Quaternion.RotateTowards(transform.rotation, OpenDoor, 20f * Time.deltaTime * 5);
    
        }
        else
        {
              transform.rotation = Quaternion.RotateTowards(transform.rotation, CloseDoor, 20f * Time.deltaTime * 5);
        }
    }
}
