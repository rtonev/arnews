using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YesWelcome : MonoBehaviour {
   


    void OnSelect()
    {
        Hide();
        GameObject.Find("welcome_screen").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("news_list").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("more").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("details").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("quit").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
    }

    void OnReset()
    {
        Hide();
    }
    void Hide()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
   
}
