#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace QFramework
{
	public static class CopyText2Clipboard
	{
#if UNITY_EDITOR
		[MenuItem("QFramework/2.复制文本到剪切板")]
#endif
		private static void CopyText()
		{
			GUIUtility.systemCopyBuffer = "要复制的关键字";
		}
	}
}