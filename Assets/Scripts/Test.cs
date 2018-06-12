using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	[SerializeField]
	private Text size;
	private readonly string format = "Width: {0}, Height: {1}\nSafe X: {2}, Safe Y: {3}\nSafe Width: {4}\nSafe Height: {5}";

	// Use this for initialization
	void Start () {
		var screenSize = ScreenUtil.safeArea;

		size.text = string.Format (format, Screen.width, Screen.height, screenSize.x, screenSize.y, screenSize.width, screenSize.height);
		Debug.Log(size.text);
	}
}
