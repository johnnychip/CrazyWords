using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	[SerializeField]
	private Database myDatebase;

	[SerializeField]
	private GameObject backButton;

	[SerializeField]
	private GameObject imageModeScreen;

	[SerializeField]
	private GameObject wordsModeScreen;

	[SerializeField]
	private GameObject abstractModeScreen;

	[SerializeField]
	private GameObject mainMenuScreen;

	[SerializeField]
	private Image[] imagesTrio;

	[SerializeField]
	private Text[] wordsTrio;

	[SerializeField]
	private Image[] abstractImage;

	public static UIManager Singleton
	{
		get; private set;
	}

	void Awake ()
	{
		if(Singleton!=null)
			DestroyImmediate(gameObject);
		else
			Singleton = this;
	}

	public void SetActiveImageMode(bool state)
	{
		mainMenuScreen.SetActive(false);
		imageModeScreen.SetActive(true);
		backButton.SetActive(true);
		SetImageTrio();

	}

	public void SetImageTrio()
	{	
		List<int> numsAdded = new List<int>();

		foreach(Image temp in imagesTrio)
		{
			int randomNum = 0; 
			do 
			{
				randomNum = Random.Range(0,myDatebase.imageBase.Length);
			}while(numsAdded.Contains(randomNum));
			numsAdded.Add(randomNum);
			temp.sprite = myDatebase.imageBase[randomNum];
		}
	}

	public void SetActiveWordsMode(bool state)
	{
		mainMenuScreen.SetActive(false);
		wordsModeScreen.SetActive(true);
		backButton.SetActive(true);
	}

	public void SetWordsTrio()
	{	
		List<int> numsAdded = new List<int>();

		foreach(Text temp in wordsTrio)
		{
			int randomNum = 0; 
			do 
			{
				randomNum = Random.Range(0,myDatebase.wordsBase.Length);
			}while(numsAdded.Contains(randomNum));
			numsAdded.Add(randomNum);
			temp.text = myDatebase.wordsBase[randomNum];
		}
	}

	public void SetActiveAbstractMode(bool state)
	{
		mainMenuScreen.SetActive(false);
		abstractModeScreen.SetActive(true);
		backButton.SetActive(true);
	}

	public void SetActiveMainMenuMode(bool state)
	{
		imageModeScreen.SetActive(false);
		wordsModeScreen.SetActive(false);
		abstractModeScreen.SetActive(false);
		mainMenuScreen.SetActive(true);
		backButton.SetActive(false);
	}

}
