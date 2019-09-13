using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onhit : MonoBehaviour
{

    public movements mov;
    public Canvas can;
    public Text txt;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "collision")
        {
            txt.text = "";

            mov.enabled = false;
            can.enabled = true;
        }
    }
}
