using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SE_PuzzleEvent : MonoBehaviour {

<<<<<<< HEAD
    [SerializeField] protected bool m_completed = false;
    [SerializeField] UnityEvent m_onCompleteEvent;
=======
    [SerializeField]
    protected bool m_completed = false;
    AudioClip Announcement;
>>>>>>> ecdb3b071f2f97f638a2d92c770b4cc0ab331bc9

    public bool Completed
    {
        get
        {
            return m_completed;
        }
    }

    public virtual void CompleteEvent( ) {
        m_onCompleteEvent.Invoke();
    } 
}
