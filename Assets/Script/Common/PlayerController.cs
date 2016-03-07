using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.Movement ();
	}

	void Movement(){
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector2.left * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		} 
		else if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector2.left * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}
	}
}
