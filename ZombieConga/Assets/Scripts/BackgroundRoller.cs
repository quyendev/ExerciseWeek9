using UnityEngine;
using System.Collections;

public class BackgroundRoller : MonoBehaviour {

	public float speed = 0.05f; 
	
	// Update is called once per frame
	void Update () {
	
		Vector2 offset = new Vector2 (Time.time * speed, 0); 
		renderer.material.mainTextureOffset = offset; 
	}
}
