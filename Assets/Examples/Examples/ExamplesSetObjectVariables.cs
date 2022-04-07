using UnityEngine;
using Unity.VisualScripting;
using SimplifyUVS;

public partial class Examples : MonoBehaviour
{
	void SetObjectVariable()
	{
		Debug.Log("Create Object Variable Instance");
		CustomEvent.Trigger(basicScript, "OnCreateObjectVariables");

		Debug.Log("Show Object Variable Information");
		CustomEvent.Trigger(basicScript, "OnShowObjectVariable");
	}
}
