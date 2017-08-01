using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_TabletTouch : MonoBehaviour {

    [SerializeField] private UnityEngine.UI.Text m_inputField;

    [SerializeField] private string m_passcode = "1234";


    void OnTriggerEnter(Collider other) {
        switch (SE_TabletScreenState.GetCurState()) {
            case SE_TabletScreenState.eScreenState.LOCK_SCREEN: {
                    if(other.tag == "TabletKeypad") {
                        SE_LockScreen lockScreen = other.transform.parent.parent.GetComponent<SE_LockScreen>();
                        lockScreen.UpdateLockScreen(other, "TabletKeypad");
                    }
                    break;
            }
            case SE_TabletScreenState.eScreenState.HOME_SCREEN: {
                    if (other.tag == "CameraApp" || other.tag == "NotesApp") {
                        SE_HomeScreen homeScreen = other.transform.parent.GetComponent<SE_HomeScreen>();
                        homeScreen.UpdateHomeScreen(other, "NotesApp", "CameraApp");
                    }
                    break;
                }
            case SE_TabletScreenState.eScreenState.CAMERA_APP: {
                    if (other.tag == "SwapCamera") {
                        SE_CameraScreen cameraScreen = other.transform.parent.parent.GetComponent<SE_CameraScreen>();
                        cameraScreen.SwapCamera();
                    } else if (other.tag == "HomeScreen") {
                        SE_TabletScreenState.SwapToState(SE_TabletScreenState.eScreenState.HOME_SCREEN);
                    } else if (other.tag == "TakePhoto") {
                        SE_CameraScreen cameraScreen = other.transform.parent.parent.GetComponent<SE_CameraScreen>();
                        StartCoroutine(cameraScreen.TakePhoto());
                    }
                    break;
                }
            case SE_TabletScreenState.eScreenState.NOTES_APP: break;
        }
        
    } 

    public void SetupInputField()
    {
        m_inputField = GameObject.Find("Input").GetComponent<UnityEngine.UI.Text>();
    }
    
}
