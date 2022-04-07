using Unity.VisualScripting;
using UnityEngine;

namespace SimplifyUVS
{
	// Reference:
	// https://docs.unity3d.com/Packages/com.unity.visualscripting@1.7/manual/vs-creating-custom-visual-script-event-node.html

	[UnitTitle("On Example Custom Event")]
	[UnitCategory("Events\\CustomEvents")]
	public class SimpleCustomEvent : EventUnit<ExampleData>
	{
		[DoNotSerialize]
		public ValueOutput result { get; private set; }
		protected override bool register => true;

		public override EventHook GetHook(GraphReference reference)
		{
			// Set Here For Event Name
			return new EventHook("MyCustomEventWithExampleData");
		}

		protected override void Definition()
		{
			base.Definition();
			// Override This Method If Argument is needed
			result = ValueOutput<ExampleData>(nameof(result));
		}

		protected override void AssignArguments(Flow flow, ExampleData data)
		{
			// Override This Method If Argument is needed
			flow.SetValue(result, data);
		}
	}
}
