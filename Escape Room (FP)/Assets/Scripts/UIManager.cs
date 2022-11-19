using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
	public GameObject ControlsUI;
	public GameObject InventoryUI;
	public GameObject LetterOpener;
	public GameObject Fork;
	public GameObject Letter;
	public GameObject Gun;
	public GameObject Key;
	public GameObject TvPic;
	public GameObject DVRPic;
	public TextMeshProUGUI InfoText;
	public AudioSource ButtonStart;
	public static UIManager UIMInstance;

	private Color transparent;

	private void Awake()
	{
		UIMInstance = this;

		transparent = new Color(1, 1, 1, 0);
	}

	public void ManageControlsUI()
	{
		if (ControlsUI.activeSelf == true)
		{
			ControlsUI.SetActive(false);
		}
		else
		{
			ControlsUI.SetActive(true);
		}
	}

	public void ManageInventoryUI()
	{
		if (InventoryUI.activeSelf == true)
		{
			InventoryUI.SetActive(false);
		}
		else
		{
			InventoryUI.SetActive(true);
		}
	}

	public void StartButton()
	{
		ButtonStart.Play();
		SceneManager.LoadScene(1);
	}

	public void ShowInfoText(int infoVersion)
	{
		if(infoVersion == 1)
		{
			InfoText.SetText("looks like i can use it");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
		else if(infoVersion == 2)
		{
			InfoText.SetText("something is missing..");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
		else if (infoVersion == 3)
		{
			InfoText.SetText("it's locked..");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
		else if (infoVersion == 4)
		{
			InfoText.SetText("it's empty");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
		else if (infoVersion == 5)
		{
			InfoText.SetText("weird");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
		else if (infoVersion == 6)
		{
			InfoText.SetText("oh fuck !");
			StartCoroutine(Fade(transparent, Color.white, 1f));
			StartCoroutine(WaitAndFadeOut(1f));
		}
		else if (infoVersion == 7)
		{
			InfoText.SetText("wtf..");
			StartCoroutine(Fade(transparent, Color.white, 1f));
			StartCoroutine(WaitAndFadeOut(1f));
		}
		else if (infoVersion == 8)
		{
			InfoText.SetText("nothing here..");
			StartCoroutine(Fade(transparent, Color.white, 3f));
			StartCoroutine(WaitAndFadeOut(3f));
		}
	}

	IEnumerator WaitAndFadeOut(float time)
	{
		yield return new WaitForSeconds(time);
		StartCoroutine(Fade(Color.white, transparent, 1f));
	}
	IEnumerator Fade(Color start, Color end, float duration)
	{
		for (float t = 0f; t < duration; t += Time.deltaTime)
		{
			float normalizedTime = t / duration;
			
			InfoText.color = Color.Lerp(start, end, normalizedTime);
			yield return null;
		}
		InfoText.color = end; 
	}

}
