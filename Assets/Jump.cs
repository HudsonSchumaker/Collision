using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float force = 225.0f;
	public Rigidbody2D ball;
	public bool isJumpping = false;
	public int x2 = 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(Input.GetAxis ("Horizontal")*Time.deltaTime,0,0));
		if(duplo > 0){
			
			if(Input.GetAxis ("A") == 1.0f){
				ball.AddForce (new Vector2 (0.0f, force * Time.deltaTime), ForceMode2D.Impulse);
				--x2;
			}
		}
	}

	// Used when the collider is set to trigger
	void OnCollisionEnter2D(Collision2D o){
		if(o.gameObject.CompareTag("Ground")){
			x2 = 2;
			//isJumpping = true;
		}
	}
	
	// Used when the collider is set to trigger
	void OnCollisionExit2D(Collision2D o){
		if(o.gameObject.CompareTag("Ground")){
			isJumpping = false;
		}
	}
}
