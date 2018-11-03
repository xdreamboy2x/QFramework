#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace QFramework
{
	public class CustomShortCut : MonoBehaviour
	{
#if UNITY_EDITOR
		[MenuItem("QFramework/7.自定义快捷键 %e")]
		private static void MenuClicked()
		{
			EditorApplication.ExecuteMenuItem("QFramework/6.MenuItem 复用");
		}
#endif
	}
}