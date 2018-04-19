using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsTitleButton : MonoBehaviour {

    void OnSelect()
    {
        Hide();
        GameObject.Find("news_list_large").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("news_title_2_invisible").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("more").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("details").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("quit").SendMessageUpwards("Hide", SendMessageOptions.DontRequireReceiver);
        GameObject.Find("article_body_1").SendMessageUpwards("Show", SendMessageOptions.DontRequireReceiver);

    }

    void Hide()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
