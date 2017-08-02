using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_PuzzleEyeScanner : SE_PuzzleEvent {
    [SerializeField]
    ParticleSystem eyeScanner;
<<<<<<< HEAD
    AudioClip m_announcement;
    bool hasCompleted = false;
=======
    bool hasCompleted = false;
    float scanTimer = 0;
    public override void CompleteEvent( ) {
>>>>>>> ecdb3b071f2f97f638a2d92c770b4cc0ab331bc9

    public override void CompleteEvent( ) {
        base.CompleteEvent();
        SE_PuzzleEventHandler.Instance.Announcer.AddAnnouncementToQueue(m_announcement);
    }


    private void OnTriggerEnter(Collider other) {
        eyeScanner.Play();
<<<<<<< HEAD
        if(other.tag == "EyeKey" ) {
            m_completed = true;
            
=======

    }

    private void OnTriggerStay(Collider other) {
         if(other.tag == "EyeKey")
        {
            scanTimer += Time.deltaTime;
            if(scanTimer > 2.0f)
            {
                m_completed = true;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        eyeScanner.Stop();
        if (other.tag == "EyeKey")
        {
            scanTimer = 0;
>>>>>>> ecdb3b071f2f97f638a2d92c770b4cc0ab331bc9
        }
    }


}
