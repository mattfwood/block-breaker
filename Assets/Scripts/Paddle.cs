using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	[SerializeField] float screenWidthInUnits = 16f;
	[SerializeField] int min = 1;
	[SerializeField] int max = 15;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
		paddlePosition.x = Mathf.Clamp(mousePositionInUnits, min, max);
		transform.position = paddlePosition;
	}
}
