using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class article_body_2 : MonoBehaviour {

    void OnSelect()
    {
        Hide();
        GameObject.Find("article_body_3").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
    }
    void Hide()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
