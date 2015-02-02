using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnLookEnter(){
		if (renderer.enabled == true) {
			Select.puz_piece += 1;
			renderer.enabled = false;
		}

	}
}
