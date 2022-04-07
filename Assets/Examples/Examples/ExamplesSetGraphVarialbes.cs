using UnityEngine;
using Unity.VisualScripting;
using SimplifyUVS;

public partial class Examples : MonoBehaviour
{
	void SetGraphVariable()
	{
		Debug.Log("<color=green>Before</color>");
		CustomEvent.Trigger(basicScript, "OnShowGraphVariables");

		var graphReference = GraphReference.New(basicScript.GetComponent<FlowMachine>(), true);
		var graphVariables = Variables.Graph(graphReference);

		graphVariables.Set("MyGraphName", "Graph Variable");
		graphVariables.Set("MyGraphInt", 5);
		graphVariables.Set("MyGraphFloat", 10.5f);
		graphVariables.Set("MyGraphBool", true);
		graphVariables.Set("MyGraphVec3", Vector3.one);

		graphVariables.Set("MyClass", new ExampleData()
		{
			ID = "ID001",
			Number = 555,
			IsSet = true
		});

		graphVariables.Set("MyStruct", new ExampleDataStruct()
		{
			ID = "ID002",
			Number = 777,
			IsSet = true
		});

		Debug.Log("<color=green>After</color>");
		CustomEvent.Trigger(basicScript, "OnShowGraphVariables");
	}
}
