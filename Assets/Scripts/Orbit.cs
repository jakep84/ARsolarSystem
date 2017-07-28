using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public GameObject orbit; //the object that will orbit around 
	public float orbitSpeed; //speed of ortbit
	public int rotationSpeed; // speed of rotation 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (0, Time.deltaTime * 0, 0)); 
		OrbitAround (); /*make the object 1 rotate around object 2 */
	}

	void OrbitAround() 
	{
		//make object 1 orbit around m
		transform.RotateAround (orbit.transform.position, Vector3.up, orbitSpeed * Time.deltaTime); 

	}
}
