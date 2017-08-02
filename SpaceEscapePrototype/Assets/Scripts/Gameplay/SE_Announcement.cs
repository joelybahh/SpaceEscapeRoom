using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SE_Announcement {

    public SE_Announcement() {
        m_minutes = 0;
        m_seconds = 0;
        m_announcmentAudio = null;
    }

    public SE_Announcement(AudioClip a_announcmentAudio) {
        m_minutes = 0;
        m_seconds = 0;
        m_announcmentAudio = a_announcmentAudio;
    }

    [Header("Time to trigger announcement")]
    [SerializeField] private float m_minutes;
    [SerializeField] private float m_seconds;

    [Header("Announcement to play")]
    [SerializeField] private AudioClip m_announcmentAudio;

    [Header("Announcement Events")]
    [SerializeField] private UnityEvent m_OnAnnounceStart;
    [SerializeField] private UnityEvent m_OnAnnounceEnd;

    #region Getters

    public float Minutes { get { return m_minutes; } }
    public float Seconds { get { return m_seconds; } }
    public AudioClip AnnouncementAudio { get { return m_announcmentAudio; } }

    #endregion
}
