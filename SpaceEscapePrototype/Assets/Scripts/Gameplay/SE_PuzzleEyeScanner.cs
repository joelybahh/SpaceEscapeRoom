using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class SE_PuzzleEyeScanner : SE_PuzzleEvent {
    [SerializeField]
    ParticleSystem m_eyeScanner;
    [SerializeField]
    Animator m_controller; 
    AudioClip m_announcement;
    bool hasCompleted = false;
    float scanTimer = 0;

    Animator m_unfoldController;

    bool m_isInUnfoldZone = false;

    void Start()
    {
        m_unfoldController = GetComponent<Animator>();
    }

    void Update()
    {
        if(m_isInUnfoldZone)
        {

        } else {

        }
    }

    public override void CompleteEvent( ) {
        base.CompleteEvent();
        SE_PuzzleEventHandler.Instance.Announcer.AddAnnouncementToQueue(m_announcement);
    }


    private void OnTriggerEnter(Collider other) {
        m_eyeScanner.Play();

        if (other.tag == "EyeKey") {
            m_completed = true;
            m_unfoldController.SetTrigger("Unfold");
            m_isInUnfoldZone = true;
        }
    }

    private void OnTriggerStay(Collider other) {


         if(other.tag == "EyeKey") {
            scanTimer += Time.deltaTime;
            if(scanTimer > 2.0f) {
                m_completed = true;
                m_controller.SetTrigger("doorOpen");
            }
        }

    }

    private void OnTriggerExit(Collider other) {
        m_eyeScanner.Stop();       

        if (other.tag == "EyeKey") {
            scanTimer = 0;
            m_unfoldController.SetTrigger("Refold");
            m_isInUnfoldZone = false;
        }
    }


}
