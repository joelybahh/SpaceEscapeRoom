using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_PuzzleEventHandler : MonoBehaviour {
    [SerializeField]
    List<SE_PuzzleEvent> m_puzzles;

    void CompleteEvent(SE_PuzzleEvent a_event ) {
        foreach (SE_PuzzleEvent e in m_puzzles)
        {
           if(e.Completed)
            {
                e.CompleteEvent();
            }
        }
    }
}
