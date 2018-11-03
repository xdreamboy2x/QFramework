using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace QFramework
{
	public class GenerateUnityPackageName2ClipBoard 
	{
#if UNITY_EDITOR
		[MenuItem("QFramework/3.生成文件名到剪切板")]
#endif
		private static void MenuClicked()
		{
			GUIUtility.systemCopyBuffer = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_hh");		
		}
	}
}