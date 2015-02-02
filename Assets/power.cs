using UnityEngine;
using System.Collections;

public class power : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnPickupEnter(){
		if (Select.powerup_got == false) {
			Select.powerup_got = true; 
		}
		if (renderer.enabled == true) {
			renderer.enabled = false;
		}
	}
}
