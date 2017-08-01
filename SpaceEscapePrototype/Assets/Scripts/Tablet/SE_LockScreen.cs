using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_LockScreen : MonoBehaviour {

    [SerializeField]
    private UnityEngine.UI.Text m_inputField;
    [SerializeField]
    private string m_passcode = "1234";

    public void UpdateLockScreen(Collider a_other, string a_buttonTag){
        if (a_other.tag == a_buttonTag) {
            int entered = (int.Parse(a_other.gameObject.name) + 1);
            Debug.Log("You Pressed Keypad" + (int.Parse(a_other.gameObject.name) + 1));

            if (entered == 10)
            {
                m_inputField.text = "";
            }
            else if (entered == 11)
            {
                if (m_inputField.text == m_passcode)
                {
                    m_inputField.text = "success";
                    ClearInputFields();
                    SE_TabletScreenState.SwapToState(SE_TabletScreenState.eScreenState.HOME_SCREEN);
                }
                else
                {
                    m_inputField.text = "nope";
                    // TODO: wait 2 seconds, do not accept any button input, clear
                }
            }
            else
            {
                m_inputField.text += entered.ToString();
            }
        }
    }

    private void ClearInputFields() {
        m_inputField.text = "";
    }
}
