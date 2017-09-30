using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour 
{
	public UIController UIController;
	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player"))
		{
			Debug.Log ("ゴールしたよ！");
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
			UIController.ShowGameClearLabel();
		}
	}
}