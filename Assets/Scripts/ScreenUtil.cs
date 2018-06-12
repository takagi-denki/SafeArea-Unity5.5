using UnityEngine;

public static class ScreenUtil {

	public static Rect safeArea { 
		get {
// from https://qiita.com/MARQUE/items/af503d169dce524e231e
#if UNITY_5_6_OR_NEWER
			return Screen.safeArea;
#else
#if UNITY_IOS && !UNITY_EDITOR
			return SafeArea.GetSafeArea();
#else
			return new Rect(0, 0, Screen.width, Screen.height);
#endif
#endif
		} 
	}
}
