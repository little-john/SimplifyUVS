using UnityEngine;
using Unity.VisualScripting;
using SimplifyUVS;

public partial class Examples : MonoBehaviour
{
	void SetSceneVariable()
	{
		Variables.ActiveScene.Set("MySceneName", "ExampleScene");
		CustomEvent.Trigger(basicScript, "OnShowSceneVariable");
	}
}
