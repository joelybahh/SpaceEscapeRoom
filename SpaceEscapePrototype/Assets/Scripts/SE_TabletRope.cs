using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_TabletRope : MonoBehaviour {
	void Start () {
        GetComponent<CharacterJoint>().connectedBody = transform.parent.GetComponent<Rigidbody>();
	}
}
