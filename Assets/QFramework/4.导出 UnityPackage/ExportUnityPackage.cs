using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace QFramework
{
	public class ExportUnityPackage : MonoBehaviour
	{
#if UNITY_EDITOR
		[MenuItem("QFramework/4.导出 UnityPackage")]
		private static void MenuClicked()
		{
			var assetPathName = "Assets/QFramework";
			var fileName = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_hh") + ".unitypackage";
			AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
		}
#endif
	}
}