using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;

    public AudioSource kid;

    public AudioClip laugh;
    private bool startedlaugh;
    void Start()
    {
        
    }
    void StartLaugh()
    {
        startedlaugh = true;
        kid.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if(startedlaugh == false)
        {
        if(Player.GetComponentInChildren<Papper>().havepick)
        {
            StartLaugh();
            Player.GetComponentInChildren<Papper>().havepick = false;
        }
        }
    }
}
