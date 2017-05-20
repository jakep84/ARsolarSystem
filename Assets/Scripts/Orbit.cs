using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public GameObject orbiter; //the object that will orbit around 
	public float speed; //speed of ortbit

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		OrbitAround (); /*make the object 1 rotate around object 2 */
	}

	void OrbitAround() 
	{
		//make object 1 orbit around m
		transform.RotateAround (orbiter.transform.position, Vector3.up, speed * Time.deltaTime); 

	}
}
