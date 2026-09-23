using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogues dialogue;

    private void Start()
    {
        TriggerDialouge();
    }

    public void TriggerDialouge()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialogue);        
    }


}
