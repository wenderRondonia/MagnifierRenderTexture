using UnityEngine;
using UnityEngine.UI;
using System;

public class Magnifier : MonoBehaviour {
	public Camera myCamera;
	public Image magnifier;
	public Vector3 offset;
	void Update(){
		if(Input.GetMouseButton(0)){
			magnifier.transform.position = Input.mousePosition ;
		}
		myCamera.transform.localPosition = magnifier.transform.localPosition + offset;
		
	}
	
	


}