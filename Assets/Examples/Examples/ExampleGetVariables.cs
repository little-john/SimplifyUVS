using UnityEngine;
using Unity.VisualScripting;
using SimplifyUVS;
using System.Text;
using System.IO;

public partial class Examples : MonoBehaviour
{
	void GetVariables()
	{
		StringBuilder builder = new StringBuilder();

		var graphReference = GraphReference.New(basicScript.GetComponent<FlowMachine>(), true);
		var graphVariables = Variables.Graph(graphReference);

		builder.AppendLine(graphVariables.Get("MyGraphName").ToString());
		builder.AppendLine(graphVariables.Get("MyGraphInt").ToString());
		builder.AppendLine(graphVariables.Get("MyGraphFloat").ToString());
		builder.AppendLine(graphVariables.Get("MyGraphBool").ToString());
		builder.AppendLine(graphVariables.Get("MyGraphVec3").ToString());
		builder.AppendLine(graphVariables.Get("MyClass").ToString());
		builder.AppendLine(graphVariables.Get("MyStruct").ToString());
		builder.AppendLine(Variables.Object(basicScript).Get("MyObjectVariable").ToString());
		builder.AppendLine(Variables.ActiveScene.Get("MySceneName").ToString());

#if UNITY_EDITOR
		File.WriteAllText("Assets/Examples/ExampleVariables.txt", builder.ToString());
		Debug.Log("All variables are save to a file in Examples folder.");
		UnityEditor.AssetDatabase.Refresh();
#endif

	}
}
