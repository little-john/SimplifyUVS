using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Examples : MonoBehaviour
{
	internal class Example
	{
		public string Name;
		public Action Action;
	}

	[SerializeField]
	private ExampleMenu menu = null;

	[SerializeField]
	private GameObject basicScript = null;

	private List<Example> examples = new List<Example>();

	void Start()
	{
		RegisterExamples();
		string[] exampleNames = examples.Select(x => x.Name).ToArray();
		menu.MakeMenu(OnExampleSelected, exampleNames);
	}

	void OnExampleSelected(int index)
	{
		examples[index].Action?.Invoke();
	}

	void RegisterExamples()
	{
		// Add example here to run in play mode
		var registerExamples = new Example[]
		{
			new Example()
			{
				Name = "Set Graph Variable", Action = SetGraphVariable
			},
			new Example()
			{
				Name = "Set Object Variable", Action = SetObjectVariable
			},
			new Example()
			{
				Name = "Set Scene Variable", Action = SetSceneVariable
			},
			new Example()
			{
				Name = "Get All Variable", Action = GetVariables
			},
			new Example()
			{
				Name = "Send And Listen Custom Events",
				Action = SendAndListenCustomEvents
			}
		};

		examples.AddRange(registerExamples);
	}
}
