﻿using UnityEngine;
using System.Collections;

public class DeadScene : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1;

		Invoke ("Restart", 1);
	}
	
	void Restart()
	{
		Application.LoadLevelAsync (1);
	}
}
