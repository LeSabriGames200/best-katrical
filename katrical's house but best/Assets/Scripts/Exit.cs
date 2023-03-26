using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void OnTriggerEnter() 
    {
        SceneManager.LoadScene("Win");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
