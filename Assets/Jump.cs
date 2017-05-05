using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float force = 225.0f;
	public Rigidbody2D ball;
	public bool isJumpping = false;
	public int duplo = 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(Input.GetAxis ("Horizontal")*Time.deltaTime,0,0));
		if(duplo > 0){
			
			if(Input.GetAxis ("A") == 1.0f){
				ball.AddForce (new Vector2 (0.0f, force * Time.deltaTime), ForceMode2D.Impulse);
				--duplo;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D o){
		if(o.gameObject.CompareTag("Ground")){
			duplo = 2;
			//isJumpping = true;
		}
	}

//	void OnCollisionExit2D(Collision2D o){
//		if(o.gameObject.CompareTag("Ground")){
//			isJumpping = false;
//		}
//	}
}
