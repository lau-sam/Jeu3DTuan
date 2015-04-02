// ------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RestartWithRButton : MonoBehaviour {
	
	void Update () {
		if (Input.GetKey ("r")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}