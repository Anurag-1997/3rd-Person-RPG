using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[SerializeField]
public class DialogObject
{
    public string[] dialogs;
    public string charcterNames;
    public int questNumber;
}
public class DialogObjects : MonoBehaviour
{
    private Player player;
    public TMP_Text nameTextBox;
    public TMP_Text dialogTextBox;
    public int currentDialogNumber = 0;
    private DialogObject currentDialog = null;
    [Header("Dialog Objects")]
    public DialogObject dialog1;
    private void OnEnable()
    {
        switch (player.dialogNumber)
        {
            case 1:
                Debug.Log("need to replace with dialog object 1");
                PlayDialog(dialog1);
                currentDialog = dialog1;
                break;
            

            default:
                break;
        }
    }

    private void PlayDialog(DialogObject tempDialogs)
    {
        nameTextBox.text = tempDialogs.charcterNames;
        if(currentDialogNumber<tempDialogs.dialogs.Length)
        {
            dialogTextBox.text = tempDialogs.dialogs[0];
        }
        else
        {
            //end the dialog 
        }
       
    }

    public void NextDialogButton()
    {
        if(currentDialog!=null)
        {
            //need to add the logic for next button
            currentDialogNumber++;
            PlayDialog(currentDialog);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
