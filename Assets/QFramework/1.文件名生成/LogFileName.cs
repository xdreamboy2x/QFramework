#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
using System;

namespace QFramework
{
	public static class LogFileName 
	{
		#if UNITY_EDITOR
		[MenuItem("QFramework/1.生成 unitypackage 名字")]
		#endif
		private static void GenerateUnityPackageName()
		{
			Debug.Log("QFramework_" + DateTime.Now.ToString("yyyyMMdd_hh"));
		}
	}
}