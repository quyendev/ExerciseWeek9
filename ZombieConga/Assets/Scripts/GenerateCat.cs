using UnityEngine;
using System.Collections;

public class GenerateCat : MonoBehaviour {

	public GameObject cat;
	private Vector3 spawn; 
	
	
	IEnumerator Start() {
		spawn = transform.position; 
		yield return new WaitForSeconds (4); 
		Instantiate (cat, spawn, Quaternion.Euler (0, 0, 0));
		Destroy (cat, 10f); 
	}
}
