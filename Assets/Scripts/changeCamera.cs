using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour {
    public int cameraMode = 0;
    public GameObject FPS;
    public GameObject TPS;

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Camera")) {
            if (cameraMode == 1) {
                cameraMode = 0;
            } else {
                cameraMode = 1;
            }
            StartCoroutine (SwitchCamera ());
        }
    }

    IEnumerator SwitchCamera () {
        yield return new WaitForSeconds (0.1f);
        if (cameraMode == 0) {
            FPS.SetActive (true);
            TPS.SetActive (false);
        }
        if (cameraMode == 1) {
            FPS.SetActive (false);
            TPS.SetActive (true);
        }
    }
}