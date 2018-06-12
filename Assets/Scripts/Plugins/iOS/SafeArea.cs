using System.Runtime.InteropServices;
using UnityEngine;

public static class SafeArea {

	[DllImport("__Internal")]
	private static extern void GetSafeArea (out float x, out float y, out float width, out float height);


	public static Rect GetSafeArea()
	{
		float x, y, width, height = 0f;
		GetSafeArea (out x, out y, out width, out height);

		return new Rect (x, y, width, height);
	}
}
