using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace QFramework
{
	public class ReuseMenuItem : MonoBehaviour
	{
#if UNITY_EDITOR
		[MenuItem("QFramework/6.MenuItem 复用")]
		private static void MenuClicked()
		{
			EditorApplication.ExecuteMenuItem("QFramework/4.导出 UnityPackage");
			Application.OpenURL("file:///" + Path.Combine(Application.dataPath, "../"));
		}
#endif
	}
}