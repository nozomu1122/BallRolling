﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {

	private SceneManager SceanManager;
	private Button Retry;

	private void Start(){
		Retry = GameObject.Find ("Retry").GetComponent<Button> ();
		Retry.onClick.AddListener (onClickTriggered);
	}

	private void onClickTriggered(){
		Debug.Log ("stuka");
		string A = "game";
		SceneManager.LoadScene (A, LoadSceneMode.Single);
	}
}