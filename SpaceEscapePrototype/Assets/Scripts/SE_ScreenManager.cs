using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_ScreenManager : MonoBehaviour {

    public List<GameObject> tabletScreens;
	
	void Update () {
        switch (SE_TabletScreenState.GetCurState()) {
            case SE_TabletScreenState.eScreenState.LOCK_SCREEN: {
                    if (tabletScreens[0].activeSelf == true) return;
                    else {
                        tabletScreens[0].SetActive(true);
                        tabletScreens[1].SetActive(false);
                    }
                    break;
                }
            case SE_TabletScreenState.eScreenState.HOME_SCREEN: {
                    if (tabletScreens[1].activeSelf == true) return;
                    else
                    {
                        tabletScreens[1].SetActive(true);
                        tabletScreens[0].SetActive(false);
                    }
                    break;
                }
        }
	}
}
