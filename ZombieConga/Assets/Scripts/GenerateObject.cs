using UnityEngine;
using System.Linq; 
using System.Collections;

public class GenerateObject : MonoBehaviour {

	public GameObject enemy;
	private Vector3 spawn; 
	 
		
	IEnumerator Start() {

		spawn = transform.position; 
		yield return new WaitForSeconds (5); 
		Instantiate (enemy, spawn, Quaternion.Euler(0,0,0));
		Destroy (enemy, 8f); 

	}

}
