using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SE_Announcement : MonoBehaviour {
    [Header("Time to trigger announcement")]
    [SerializeField] private float m_minutes;
    [SerializeField] private float m_seconds;

    [Header("Announcement to play")]
    [SerializeField] private AudioClip m_announcmentAudio;

    [Header("Announcement Events")]
    [SerializeField]
    private UnityEvent m_OnAnnounceStart;
    private UnityEvent m_OnAnnounceEnd;
}
