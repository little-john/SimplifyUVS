using UnityEngine;
using Unity.VisualScripting;
using SimplifyUVS;

public partial class Examples : MonoBehaviour
{
	void SendAndListenCustomEvents()
	{
		// Listen Event
		EventBus.Register<ExampleData>("MyCustomEventWithExampleData", listenData =>
		{
			Debug.Log("<color=yellow>On MyCustomEvent Listener On Code</color>");
			SimplifyUVSUtil.ShowVariableInfo(listenData);
		});

		// Send Event
		ExampleData data = new ExampleData()
		{
			ID = "Awesome",
			Number = 777,
			IsSet = true
		};
		EventBus.Trigger("MyCustomEventWithExampleData", data);

		// Listen Event No Arguments
		EventBus.Register<EmptyEventArgs>("NoArgCustomEvent", empty =>
		{
			Debug.Log("<color=yellow>On NoArgCustomEvent Listener On Code</color>");
		});

		// Send Event No Arguments
		EventBus.Trigger("NoArgCustomEvent");
	}
}
