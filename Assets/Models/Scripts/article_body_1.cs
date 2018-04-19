using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class article_body_1 : MonoBehaviour {

    void OnSelect()
    {
        Hide();
        GameObject.Find("article_body_2").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);
    }
    void Hide()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }



}
