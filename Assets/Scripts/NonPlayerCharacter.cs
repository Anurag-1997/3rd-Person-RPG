using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NonPlayerCharacter : MonoBehaviour
{
    public GameObject infoText;
    public GameObject dialogText;
    bool tempInfoTextActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            //infoText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.K))
            {
                
                other.gameObject.GetComponent<Player>().dialogNumber = 1;
                dialogText.SetActive(true);
                infoText.SetActive(false);
                //tempInfoTextActive = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        infoText.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        infoText.SetActive(false);
        //dialogText.SetActive(false);
    }
}
