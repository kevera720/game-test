using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;

    public GameObject ScareAudio;

    public AudioSource kid;

    public AudioClip run;
    public AudioClip ghost;
    public AudioClip violinpunch;
    private bool startedlaugh;

    public bool openbasementDoor;

    public GameObject musicBoxLeft;
    public GameObject musicBoxRight;

    public bool basementright;

    public int basementwalk;
    void Start()
    {
        
    }
    void StartLaugh()
    {
        startedlaugh = true;
        kid.Play();
    }
    public void StartRun()
    {
        if(!openbasementDoor)
        {
        kid.clip = run;
        kid.Play();
        kid.loop = false;
        openbasementDoor = true;
        }
    }
    public void SpawnMusicBox()
    {
        basementwalk++;
        if(basementwalk < 3)
        {
        if(basementright)
        {
            musicBoxRight.SetActive(true);
            musicBoxLeft.SetActive(false);
        }
        else
        {
            musicBoxLeft.SetActive(true);
            musicBoxRight.SetActive(false);
        }
        }
        if(basementwalk >= 3)
        {
            ScareAudio.GetComponent<AudioSource>().PlayOneShot(violinpunch, 1f);
            musicBoxLeft.GetComponent<AudioSource>().clip = ghost;
             musicBoxLeft.GetComponent<AudioSource>().Play();
              musicBoxLeft.GetComponent<AudioSource>().loop = false;
               musicBoxRight.GetComponent<AudioSource>().clip = ghost;
             musicBoxRight.GetComponent<AudioSource>().Play();
              musicBoxRight.GetComponent<AudioSource>().loop = false;
        }
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
