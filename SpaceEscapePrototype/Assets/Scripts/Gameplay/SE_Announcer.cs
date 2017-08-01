using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SE_OxygenTimer))]
public class SE_Announcer : MonoBehaviour {

    [SerializeField] private List<SE_Announcement>  m_timedAnnouncements;
    private Queue<SE_Announcement>  m_curAnnouncementsQ;

    private SE_OxygenTimer m_o2Timer;
    private AudioSource m_audioSource;

    void Start () {
        m_o2Timer = GetComponent<SE_OxygenTimer>();
        m_audioSource = GetComponent<AudioSource>();
        m_timedAnnouncements = new Queue<SE_Announcement>();
	}
	
    void Update() {

        // loop through all the timed announcements
        for(int i = 0; i < m_timedAnnouncements; i++) {
            // if both the clock, and the current timed events minutes are the same
            if ( (int)m_timedAnnouncements[i].Minutes == (int)m_o2Timer.m_o2Clock.Minutes) {
                // check if the seconds are also the same
                if ( (int)m_timedAnnouncements[i].Seconds == (int)m_o2Timer.m_o2Clock.Seconds ) {
                    // if so add it to the queue
                    m_curAnnouncementsQ.Enqueue(m_timedAnnouncements[i]);
                }
            }
        }

        if(m_curAnnouncementsQ.Count > 0 ) {
            PlayAnouncement();
        }
    }

    private void PlayAnouncement() {
        SE_Announcement toPlay = m_curAnnouncementsQ.Dequeue();
        m_audioSource.PlayOneShot(toPlay.m_announcmentAudio);
    }

	public void AddAnnouncementToQueue(SE_Announcement a_announcement) {
        m_timedAnnouncements.Enqueue(a_announcement);
    }

    public void PlayEventAnnouncement() {
        //AddAnnouncementToQueue();
    }
}
