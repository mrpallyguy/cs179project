using UnityEngine;
using System.Collections;

public class PowerupListener : MonoBehaviour {

	GameObject player;
	Transform powerUp;
	CapsuleCollider capsuleCollider;
	bool playerInRange;
	float timeOfPowerUp = 5f;
	float timer;


	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		powerUp = GetComponent <Transform> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();
		playerInRange = false;
		timer = 0;
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			playerInRange = true;
		}
	}
		
	// Update is called once per frame
	void Update () 
	{
		if (playerInRange) 
		{
			Vector3 test = new Vector3 (100, 100, 100);
			PlayerShooting.timeBetweenBullets = 0.05f;
			PlayerShooting.damagePerShot = 200;
			powerUp.Translate (test);
		} 
		else 
		{
			powerUp.Rotate (Vector3.left, 100 * Time.deltaTime);
		}
	}
}
