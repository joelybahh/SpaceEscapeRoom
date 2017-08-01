using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_PuzzleEyeScanner : SE_PuzzleEvent {

    public override void CompleteEvent( ) {

        m_completed = true;
    }

    private void Update( ) {
        Debug.Log("sdashkfnaskd");
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("entered " + other.name);
        if(other.tag == "EyeKey" ) {
            CompleteEvent();
        }
    }
}
