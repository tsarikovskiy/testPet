﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject splashImg;
	public AudioSource menuMusic;
	public GameObject canvas;
	public GameObject monstersCanvas;
	public GameObject workshopCanvas;

	public GameObject collectionView;

	Animator canvasAnim;

	// Use this for initialization
	void Start () 
	{
		Invoke ("HideSplash", .5f);
		Invoke ("MovePlatform", 1f);
		canvasAnim = canvas.GetComponent<Animator> ();
	}

	void MovePlatform ()
	{
		canvas.SetActive (true);
	}

	void HideSplash ()
	{
		menuMusic.Play ();
		splashImg.SendMessage ("StartHide");
	}
	
	public void PlayPressed () 
	{
		Application.LoadLevel ("MainScene");
	}

	public void MonstersCollectionPressed ()
	{
		canvasAnim.SetBool ("hideMenu", true);	
	}

	public void WorkShopPressed ()
	{
		canvasAnim.SetBool ("hideMenu", true);
	}

	public void BackPressed ()
	{ 
		canvasAnim.SetBool ("hideMenu", false);
	}
}
