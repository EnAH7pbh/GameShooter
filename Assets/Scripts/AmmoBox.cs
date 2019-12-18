using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            WeaponControler.ammoMag = 90;
        }
    }
}
