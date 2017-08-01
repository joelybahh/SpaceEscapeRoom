using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SE_OxygenTimer))]
public class SE_Announcer : MonoBehaviour {

    [SerializeField] private List<SE_Announcement>  m_announcements;
    private Queue<SE_Announcement>  m_announcementsQ;

    private SE_OxygenTimer m_o2Timer;
    private AudioSource m_audioSource;

    void Start () {
        m_o2Timer = GetComponent<SE_OxygenTimer>();
        m_audioSource = GetComponent<AudioSource>();
        m_announcements = new Queue<SE_Announcement>();
	}
	
    void Update() {
        for(int i = 0; i < m_announcements; i++) {
            if ( m_announcements[i].Minutes == m_o2Timer.m_o2Clock.Minutes) {
                if ( m_announcements[i].Seconds == m_o2Timer.m_o2Clock.Seconds ) {
                    m_announcementsQ.Enqueue(m_announcements[i]);
                }
            }
        }

        if(m_announcementsQ.Count > 0 ) {
            SE_Announcement toPlay = m_announcementsQ.Dequeue();
            m_audioSource.PlayOneShot(toPlay.m_announcmentAudio);
        }
    }

    private void PlayAnouncement;

	public void AddAnnouncementToQueue(SE_Announcement a_announcement) {
        m_announcements.Enqueue(a_announcement);
    }

    public void PlayEventAnnouncement() {
        //AddAnnouncementToQueue();
    }
}
