using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class more : MonoBehaviour {

    void OnSelect()
    {
        Hide();
        GameObject.Find("news_list").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("news_list_large").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("news_title_2_invisible").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
    }
    void Hide()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
