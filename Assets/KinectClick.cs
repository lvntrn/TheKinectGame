using UnityEngine;
using System.Collections;

public class KinectClick : MonoBehaviour {

    private InteractionManager manager;
    private int count = 0;
    private GameObject[] controller;

    // Use this for initialization
    void Start () {
        manager = InteractionManager.Instance;
        Cursor.visible = false;
        controller = GameObject.FindGameObjectsWithTag("KinectController");
    }

    // Update is called once per frame
    void Update() {
        if (manager != null && manager.IsInteractionInited()) {

           /* if (manager.IsLeftHandPrimary()) {
                // if the left hand is primary, check for left hand grip
                if (manager.GetLastLeftHandEvent() == InteractionManager.HandEventType.Grip) {

                }
            }
            else if (manager.IsRightHandPrimary()) {
                // if the right hand is primary, check for right hand grip
                if (manager.GetLastRightHandEvent() == InteractionManager.HandEventType.Grip) {

                }
            }*/
        }
        Debug.Log(controller);
        //Debug.Log(manager.GetRightHandClickProgress());
    }
}
