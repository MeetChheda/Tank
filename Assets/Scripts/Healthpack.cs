using UnityEngine;
using System.Collections;

public class Healthpack : MonoBehaviour {

	public float destroyTime = 15.0f;

	// Update is called once per frame
	void Start(){

Destroy (gameObject, destroyTime);

	}
	void Update () {
	 transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}



}
