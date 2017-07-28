using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_TabletScreenState {
    public enum eScreenState {
        LOCK_SCREEN,
        HOME_SCREEN,
        CAMERA_APP,
        NOTES_APP
    }

    private static eScreenState curTabletState = eScreenState.LOCK_SCREEN;

    public static void SwapToState(eScreenState a_state) {
        curTabletState = a_state;
    }

    public static eScreenState GetCurState() {
        return curTabletState;
    }
}
