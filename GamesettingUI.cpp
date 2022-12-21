using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeControll : MoonBehaviour
{
	private AudioSource menuAudio;
	private Slider audioslider;
	void start()
	{
		menuAudio = GameObject.FinfGameObjectWithTag("mainMenu").transform.GetComponent<AudioSource>();
		audioSlider = GetComponent<Slider>();//GameObject.FindGameObjectWithTag("gameSettingUI").transform.GetComponent<Slider>(); 
	}
	void Update()
	{
		VolumeControll();
		ClosegameSettingUI();
	}
	public void VolumeControll()
	{
		menuAudio.volume = audioSlider.value;
		
	}
	public void CloseGameSettingUI()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			GameObject mainMenu = GameObject.FinfGameObjectWithTag("mainMenu").transform.gameObject;
			GameObject gameSettingUI = GameObject.FinfGameObjectWithTag("gameSettingUI").transform.gameObject;
			mainMenu.transform.GetChild(0).gameObject.SetActive(true);
			gameSettingUI.transform.GetChild(0).gameObject.SetActive(false);
		}
	}
	
	
	
	
	
	
	
}
