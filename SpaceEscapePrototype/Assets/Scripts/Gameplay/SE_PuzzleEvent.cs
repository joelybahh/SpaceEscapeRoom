using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_PuzzleEvent : MonoBehaviour {

    [SerializeField]
    protected bool m_completed = false;
    public bool Completed
    {
        get
        {
            return m_completed;
        }
    }
    public virtual void CompleteEvent( ) {

    } 
}
