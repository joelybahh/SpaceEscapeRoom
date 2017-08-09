using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Floor : MonoBehaviour {

	void UnlockFloor( ) {
        tag = "Teleportable";
    }

    void LockFloor( ) {
        tag = "TeleportableLocked";
    }
}
