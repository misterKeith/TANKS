using UnityEngine;
using System.Collections;

public class CannonShooter : MonoBehaviour {
	
	public Rigidbody machineGunPrefab;
	public Rigidbody mainCannonPrefab;
	public GameObject machineGunLauncher;
	public GameObject cannonLauncher;
	
	void Update () 
	{
		
		if(Input.GetMouseButtonDown(0)) {       //if you left click on the mouse...
			Debug.Log("Machine Gun");
			Rigidbody clone;
			clone = Instantiate(machineGunPrefab, machineGunLauncher.transform.position, machineGunLauncher.transform.rotation) as Rigidbody;
			clone.velocity = machineGunLauncher.transform.forward * 1000f;
			Destroy(clone.gameObject,2);
	}	

		if(Input.GetMouseButtonDown(1)) {      //if you right click on the mouse...
			Debug.Log ("Main Cannon");
	  		Rigidbody clone;
			clone = Instantiate(mainCannonPrefab, cannonLauncher.transform.position, cannonLauncher.transform.rotation) as Rigidbody;
			clone.velocity = cannonLauncher.transform.forward * 800f;
			Destroy(clone.gameObject,2);
        }
	
	}
	

}