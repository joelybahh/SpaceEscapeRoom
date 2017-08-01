using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Announcer : MonoBehaviour {

    private Queue<SE_Announcement>  m_announcements;
    
    void Start () {
        m_announcements = new Queue<SE_Announcement>();
	}
	
	public void AddAnnouncementToQueue(SE_Announcement a_announcement) {
        m_announcements.Enqueue(a_announcement);
    }

    public void PlayEventAnnouncement() {
        //AddAnnouncementToQueue();
    }
}
