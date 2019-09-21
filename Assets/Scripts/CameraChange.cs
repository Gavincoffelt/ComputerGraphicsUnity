using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour
{
    public Camera Main;
    public Camera Firework;
    // Used by the Dropdown box to switch between the two cameras.
    public void CamSwitch()
    {
        if (GetComponent<Dropdown>().value.Equals(0))
        {
            Firework.enabled = false;
            Main.enabled = true;
        }
        else if (GetComponent<Dropdown>().value.Equals(1))
        {
            Main.enabled = false;
            Firework.enabled = true;
        }
    }
}
