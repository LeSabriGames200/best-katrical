using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KatricalSong : MonoBehaviour
{
    public GameObject somethingyousteal;
    public GameObject katrical;
    public GameObject katricalbad;
    public GameObject music;
    public GameObject exit;
    public Text Mission;

    public void OnTriggerStay() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            somethingyousteal.SetActive(false);
            katrical.SetActive(false);
            katricalbad.SetActive(true);
            music.SetActive(false);
            exit.SetActive(true);
            Mission.text = "LEAVE";
        }
    }
}

