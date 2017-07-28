using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_TabletTouch : MonoBehaviour {

    [SerializeField] private UnityEngine.UI.Text InputField;

    [SerializeField] private string passcode;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "TabletKeypad") {
            int entered = (int.Parse(other.gameObject.name) + 1);
            Debug.Log("You Pressed Keypad" + (int.Parse(other.gameObject.name) + 1));  
            
            if(entered == 10) {
                InputField.text = "";
            } else if(entered == 11) {
                if(InputField.text == "1234") {
                    InputField.text = "success";
                } else {
                    InputField.text = "nope";

                }
            } else {
                InputField.text += entered.ToString();
            }      
        }
    } 

    public void SetupInputField()
    {
        InputField = GameObject.Find("Input").GetComponent<UnityEngine.UI.Text>();
    }
}
