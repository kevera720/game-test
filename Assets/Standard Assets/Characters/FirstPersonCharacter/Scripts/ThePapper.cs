using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThePapper : MonoBehaviour
{
    // Start is called before the first frame update]
    public GameObject Player;
    public int id;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void ShowPapper()
    {
        Player.GetComponentInChildren<Papper>().paperid = id;
        if(Player.GetComponentInChildren<Papper>().showText)
        {
            Player.GetComponentInChildren<Papper>().showText = false;
        }
        else
        {
            Player.GetComponentInChildren<Papper>().showText = true;
        }
    }
}
