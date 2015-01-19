using UnityEngine;
using System.Collections;

public class PlayerFootsteps : MonoBehaviour {

	public AudioClip ground;

	bool step = true;
	bool playing = false;
	float audioLength = 0.3f;
	float elapTime = 0f;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		CharacterController controller = GetComponent<CharacterController> ();

		if (controller.isGrounded && controller.velocity.magnitude < 7 && 
						controller.velocity.magnitude > 5 && hit.gameObject.tag == "Ground" && step == true ||
		    controller.isGrounded && controller.velocity.magnitude < 7 && 
		    controller.velocity.magnitude > 5 && hit.gameObject.tag == "Untagged" && step == true) 
		{
			walkOnGround();
		}
	}

	void walkOnGround()
	{
		/*
		if (!playing) 
		{
			step = false;
			playing = true;
			elapTime = 0f;
			audio.clip = ground;
			audio.Play ();
			step = true;
		}
		*/

		if(!audio.isPlaying)
		{
			audio.clip = ground;
			audio.Play ();
		}
		
	}

	void Update()
	{
		if(playing)
		{
			elapTime += Time.deltaTime;
			if(elapTime >= audioLength)
			{
				playing = false;
			}
		}
	}
	
}
