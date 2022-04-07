using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SimplifyUVS
{
	// Reference:
	// https://docs.unity3d.com/Packages/com.unity.visualscripting@1.7/manual/vs-creating-custom-visual-script-event-node.html

	[UnitTitle("On No Arg Example Custom Event")]
	[UnitCategory("Events\\CustomEvents")]
	public class NoArgCustomEvent : EventUnit<EmptyEventArgs>
	{
		protected override bool register => true;

		public override EventHook GetHook(GraphReference reference)
		{
			// Set Here For Event Name
			return new EventHook("NoArgCustomEvent");
		}
	}
}
