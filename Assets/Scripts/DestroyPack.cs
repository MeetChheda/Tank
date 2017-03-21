using UnityEngine;
using System.Collections;

public class DestroyPack : MonoBehaviour {
	public float destroyTime = 15.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
