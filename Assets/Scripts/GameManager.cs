using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	
	public static GameManager Singleton
	{
		set; private get;
	}

	void Awake () 
	{
		if(Singleton!=null)
			DestroyImmediate(gameObject);
		else
			Singleton = this;
	}
	
	public void SetImageMode ()
	{
		UIManager.Singleton.SetActiveImageMode(true);
	}

	public void SetWordsMode ()
	{

	}

	public void SetAbstractMode ()
	{

	}

}
