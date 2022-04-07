using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleMenu : MonoBehaviour
{
	[SerializeField]
	private Transform listParnet;

	[SerializeField]
	private Button templateButton;

	void Awake()
	{
		templateButton.gameObject.SetActive(false);
	}

	public void MakeMenu(Action<int> onClick, params string[] menuItemNames)
	{
		int i = 0;
		foreach (var menuName in menuItemNames)
		{
			Button newMenuItem = Instantiate(templateButton.gameObject, listParnet).GetComponent<Button>();
			newMenuItem.gameObject.SetActive(true);
			newMenuItem.GetComponentInChildren<Text>().text = menuName;
			int clickIndex = i++;
			newMenuItem.onClick.AddListener(() => {
				onClick?.Invoke(clickIndex);
			});
		}
	}
}
