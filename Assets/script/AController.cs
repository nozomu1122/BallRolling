using System.Collections;
using UnityEngine;

public class AController : MonoBehaviour 
{
	public UI2Controller UI2Controller;
	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player"))
		{
			Debug.Log ("ダメだったよ");
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
			UI2Controller.ShowBLabel ();
			UI2Controller.ShowRetry ();
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
