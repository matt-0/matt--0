using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	void Update(){
		if(Input.GetKey(KeyCode.A)){
			rigidbody.velocity = new Vector3(-3, rigidbody.velocity.y, rigidbody.velocity.z);
		} else if(Input.GetKey(KeyCode.D)){
			rigidbody.velocity = new Vector3(3, rigidbody.velocity.y, rigidbody.velocity.z);
		} /*else if(Input.GetKey(KeyCode.RightArrow)){
			var newScale = rigidbody.transform.localScale;
			if (newScale.x < 3){
				newScale.x += .01f;
				rigidbody.transform.localScale = newScale;
			}
		} else if(Input.GetKey(KeyCode.LeftArrow)){
			var newScale = rigidbody.transform.localScale;
			if (newScale.x > .5f){
				newScale.x -= .01f;
				rigidbody.transform.localScale = newScale;
			}
		} */else if(Input.GetKey(KeyCode.UpArrow)){
			var newScale = rigidbody.transform.localScale;
			if (newScale.y < 3){
				newScale.y += .01f;
				rigidbody.transform.localScale = newScale;
			};
		} else if(Input.GetKey(KeyCode.DownArrow)){
			var newScale = rigidbody.transform.localScale;
			if (newScale.y > .5f){
				newScale.y -= .01f;
				rigidbody.transform.localScale = newScale;
			}
		} else {
		}
	}
}
