using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingDoorScript : MonoBehaviour
{
    public GameObject DoorOpens;
    public GameObject DoorCloses;

    private bool isOpen = false; // added variable to track if door is open

    public void OnTriggerStay()
    {
        DoorOpens.SetActive(true);
        DoorCloses.SetActive(false);
        isOpen = true; // set door state to open
    }

    public void OnTriggerExit()
    {
        if (isOpen) // only close door if it's open
        {
            DoorOpens.SetActive(false);
            DoorCloses.SetActive(true);
            isOpen = false; // set door state to closed
        }
    }
}
