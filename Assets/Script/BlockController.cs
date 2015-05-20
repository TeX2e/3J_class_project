﻿using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		transform.localPosition = new Vector3(0, 5, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// if the gameObject is out of camera range, destroy it.
	void OnBecameInvisible(){
		Destroy(gameObject);
	}

	public void MoveBlock(float x, float z) {
		Vector3 v = new Vector3(x, 0, z);
		transform.Translate(v, Space.World);
	}

	public void PitchBlock(int direct) { rotate(direct * 90, 0, 0); }
	public void YawBlock  (int direct) { rotate(0, direct * 90, 0); }
	public void RollBlock (int direct) { rotate(0, 0, direct * 90); }

	private void rotate(float x, float y, float z) {
		Vector3 v = new Vector3(x, y, z);
		transform.Rotate(v, Space.World);
	}
}
