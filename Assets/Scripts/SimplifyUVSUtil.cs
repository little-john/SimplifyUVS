using System;
using UnityEngine;

namespace SimplifyUVS
{
	public static class SimplifyUVSUtil
	{
		const string FORMAT = "Type:{0} Value:{1}";

		public static void ShowVariableInfo(object variable)
		{
			string type = variable?.GetType().ToString();
			string value = variable?.ToString();

			Debug.Log($"<color=orange>{string.Format(FORMAT,type,value)}</color>");
		}

		public static void ShowVariableInfo(params object[] variables)
		{
			foreach (object variable in variables)
			{
				ShowVariableInfo(variable);
			}
		}
	}
}
