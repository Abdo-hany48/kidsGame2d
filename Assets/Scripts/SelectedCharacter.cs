using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedCharacter : MonoBehaviour {

	private Sprite chara;
	public GameObject selectedChara;
	void Start()
	{
		DontDestroyOnLoad(selectedChara);
		selectedChara.AddComponent(typeof(Image));
		if (StaticData.chosenCharacter==true)
		{
			Debug.Log("added male image");
			chara = Resources.Load<Sprite>("Male Character 2");
		}
		else 
		{
			Debug.Log("added female image");
			chara = Resources.Load<Sprite>("Female_Character-removebg");
		}
		selectedChara.GetComponent<Image>().sprite = chara;

		RectTransform rectTransform = selectedChara.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(150, 230); // Set the width to 200 and height to 300

	}
	
}
