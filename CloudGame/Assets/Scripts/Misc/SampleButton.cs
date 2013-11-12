using UnityEngine;
using System.Collections;

public class SampleButton : MonoBehaviour {

	public void OnGUI(){
		if(GUI.Button(new Rect(5, 5, 100, 25), "Button")){
			print("Button clicked.");
		}
	}
}
