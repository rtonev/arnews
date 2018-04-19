using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleButtonResponder : MonoBehaviour {

    void Hide() {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }

    void Show() {
        GetComponent<Renderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
    }
}
