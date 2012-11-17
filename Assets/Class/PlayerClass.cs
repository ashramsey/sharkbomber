using UnityEngine;
using System.Collections;

public class PlayerClass : MonoBehaviour {
	public float speed;
	
	
	// Use this for initialization
	void Start () {
		var x = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 50) {
			//get new speed
			speed = Random.Range(8f,12f);
			transform.position = new Vector3( -40f, transform.position.y, transform.position.z );
		}		
		transform.Translate(0,  0, speed * Time.deltaTime);
		Debug.Log(Time.deltaTime);
		
		
	}
	

}


