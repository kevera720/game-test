using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Papper : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject paper;
    public GameObject text;

    public bool showText;

    public int paperid;

    private string textPaper;

    public bool havepick;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

                        
        if(paperid == 1)
        {
            textPaper = "Hey Steve, I'll be back tomorrow, take care of your brother Max.\n\nDaddy.";
        }
        if(paperid == 2)
        {
            textPaper = "Hello brother, I wants to play Hide n' Sick with you, Find me\n\nMax.";
        }
        text.GetComponent<TMP_Text>().text = textPaper;
        if(showText)
        {
            havepick = true;
            paper.SetActive(true);
            text.SetActive(true);

                        if(Input.GetKeyDown(KeyCode.F))
                        {  
                                showText = false;

                        }
        }  
        else
        {
            paper.SetActive(false);
            text.SetActive(false);
        } 
    }
}
