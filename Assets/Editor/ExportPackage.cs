using System.IO;
using UnityEngine;
using UnityEditor;

public static class ExportPackage {

	[MenuItem("Assets/Export SafeArea Package")]
	public static void Export() {
		var names = new []{"Assets/Scripts/ScreenUtil.cs", 
						   "Assets/Scripts/Plugins/iOS/SafeArea.cs",
						   "Assets/Scripts/Plugins/iOS/SafeArea.mm"};
		if (!Directory.Exists (Path.Combine(Directory.GetCurrentDirectory(), "build"))) {
			Directory.CreateDirectory (Path.Combine(Directory.GetCurrentDirectory(), "build"));
		}

		AssetDatabase.ExportPackage (names, "build/SafeArea.unitypackage");
	}

}
