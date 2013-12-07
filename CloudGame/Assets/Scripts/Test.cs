using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Update(){
		if(Input.GetKey(KeyCode.A)){
			rigidbody.velocity = new Vector3(-3, rigidbody.velocity.y, rigidbody.velocity.z);
		} else if(Input.GetKey(KeyCode.D)){
			rigidbody.velocity = new Vector3(3, rigidbody.velocity.y, rigidbody.velocity.z);
		} else {
			//rigidbody.velocity = Vector3.zero;
		}
	}
}
