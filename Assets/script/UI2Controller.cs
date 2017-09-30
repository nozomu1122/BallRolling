using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UI2Controller : MonoBehaviour 
{
	public Text BLabel;
	public Button Retry;

	private void Start () 
	{
		BLabel.gameObject.SetActive (false);
		Retry.gameObject.SetActive (false);
	}
	public void ShowBLabel()
	{
		BLabel.gameObject.SetActive (true);
	}

	public void ShowRetry()
	{
		Retry.gameObject.SetActive (true);
	}

	void Update ()
	{
		
	}
}
