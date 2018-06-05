using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;  

public class Board : MonoBehaviour {  

	public Text text;  

	void Start()  
	{   
		this.gameObject.GetComponent<Button>().onClick.AddListener(click);  
	}  

	void click()  
	{  
		if (text.gameObject.activeSelf)  
			StartCoroutine(open());  
		else  
			StartCoroutine(close());  
	}  

	IEnumerator open()  
	{  
		float deltaX = 0f;  
		float deltaY = 100f;  
		for (int i = 0; i < 10; i++)  
		{  
			text.gameObject.SetActive(false);  
			deltaX =deltaX - 9f;  
			deltaY =deltaY - 10f;  
			text.transform.rotation = Quaternion.Euler(deltaX, 0, 0);  
			text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, deltaY);  
			yield return null;  
		}  
	}  

	IEnumerator close()  
	{  
		float deltaX = -90f;  
		float deltaY = 0f;  
		for (int i = 0; i < 10; i++)  
		{  
			text.gameObject.SetActive(true); 
			deltaX =deltaX + 9f;  
			deltaY =deltaY + 10f;  
			text.transform.rotation = Quaternion.Euler(deltaX, 0, 0);  
			text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, deltaY);    
			yield return null;  
		}  
	}  
		
}  