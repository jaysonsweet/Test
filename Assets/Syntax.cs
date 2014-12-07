using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour {

	public bool booleanl1 = false;
	private bool booleanl2 = true;

	public int integer = 1;
	public float floatingPoint = 1.1f;


	// Use this for initialization
	void Start () {
	   if (booleanl1 == true) {
			Debug.Log ("Awesome");
		}

		integer = 10;
		floatingPoint = 5.4f;
	}
	
	// Update is called once per frame
	void Update () {
		integer = integer + 1;
		integer += 1;
	}
}
