using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
	public Text GameClearLabel;

	private void Start()
	{
		GameClearLabel.gameObject.SetActive (false);
	}
	// Use this for initialization
	public void ShowGameClearLabel() 
		{
		GameClearLabel.gameObject.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
