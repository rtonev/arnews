using Academy.HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GazeManager : MonoBehaviour {

    public static GazeManager Instance { get; private set; }

    public GameObject FocusedObject { get; private set; }
    private GazeStabilizer gazeStabilizer;


    GestureRecognizer recognizer;
    void Awake() {
        gazeStabilizer = GetComponent<GazeStabilizer>();

        Instance = this;
        recognizer = new GestureRecognizer();
        recognizer.Tapped += (args) => {
            // Send an OnSelect message to the focused object and its ancestors.
            if (FocusedObject != null) {
                FocusedObject.SendMessageUpwards("OnSelect", SendMessageOptions.DontRequireReceiver);
            }

         
        };
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update () {

        // Figure out which hologram is focused this frame.
        GameObject oldFocusObject = FocusedObject;

        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;
        gazeStabilizer.UpdateHeadStability(headPosition, Camera.main.transform.rotation);
        headPosition = gazeStabilizer.StableHeadPosition;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo)) {
            // If the raycast hit a hologram, use that as the focused object.
            FocusedObject = hitInfo.collider.gameObject;
        } else {
            // If the raycast did not hit a hologram, clear the focused object.
            FocusedObject = null;
        }

        // If the focused object changed this frame,
        // start detecting fresh gestures again.
        if (FocusedObject != oldFocusObject) {
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }
    }
}
