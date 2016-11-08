using UnityEngine;
using System.Collections;

public class bgscroll : MonoBehaviour {
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
		transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
	}
}
