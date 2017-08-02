using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_PuzzleEyeScanner : SE_PuzzleEvent {
    [SerializeField]
    ParticleSystem eyeScanner;
    AudioClip m_announcement;
    bool hasCompleted = false;

    public override void CompleteEvent( ) {
        base.CompleteEvent();
        SE_PuzzleEventHandler.Instance.Announcer.AddAnnouncementToQueue(m_announcement);
    }


    private void OnTriggerEnter(Collider other) {
        eyeScanner.Play();
        if(other.tag == "EyeKey" ) {
            m_completed = true;
            
        }
    }
}
