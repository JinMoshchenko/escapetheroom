using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
	public GameObject Darkness;
	public GameObject TrashBin;
	public GameObject Safe;
	public GameObject Door;
	public GameObject Drw1;
	public GameObject Drw2;
	public GameObject Drw3;
	public GameObject DeskBox1;
	public GameObject DeskBox2;
	public GameObject DeskBox3;
	public GameObject DeskBox4;
	public GameObject DeskBox5;
	public GameObject DeskBox6;
	public GameObject DeskBox7;
	public GameObject DeskBox8;
	public GameObject DeskBox9;
	public GameObject PictureFrame;
	public GameObject Suitcase;
	public GameObject Clock;
	public GameObject CreepyToy;
	public GameObject TeddyBear;

    public static AnimationManager AMInstance;

	private void Awake()
	{
		AMInstance = this;
	}


	public void LampOn()
	{
		Darkness.SetActive(false);
	}
	public void LampOff()
	{
		Darkness.SetActive(true);
	}

	public void PlayTrashBinOpenAnim()
	{
		TrashBin.GetComponent<Animation>().Play("TrashBinOpenAnim");
	}
	public void PlayTrashBinCloseAnim()
	{
		TrashBin.GetComponent<Animation>().Play("TrashBinCloseAnim");
	}

	public void PlaySafeOpenAnim()
	{
		Safe.GetComponent<Animation>().Play("SafeOpenAnim");
	}
	public void PlaySafeCloseAnim()
	{
		Safe.GetComponent<Animation>().Play("SafeCloseAnim");
	}

	public void PlayDoorAnim()
	{
		Door.GetComponent<Animation>().Play("DoorAnim");
	}
	public void PlayDoorOpenAnim()
	{
		Door.GetComponent<Animation>().Play("DoorOpenAnim");
	}

	public void PlayDrw1OpenAnim()
	{
		Drw1.GetComponent<Animation>().Play("Drw1OpenAnim");
	}
	public void PlayDrw1CloseAnim()
	{
		Drw1.GetComponent<Animation>().Play("Drw1CloseAnim");
	}

	public void PlayDrw2OpenAnim()
	{
		Drw2.GetComponent<Animation>().Play("Drw2OpenAnim");
	}
	public void PlayDrw2CloseAnim()
	{
		Drw2.GetComponent<Animation>().Play("Drw2CloseAnim");
	}

	public void PlayDrw3OpenAnim()
	{
		Drw3.GetComponent<Animation>().Play("Drw3OpenAnim");
	}
	public void PlayDrw3CloseAnim()
	{
		Drw3.GetComponent<Animation>().Play("Drw3CloseAnim");
	}

	public void PlayDeskBox1OpenAnim()
	{
		DeskBox1.GetComponent<Animation>().Play("DeskBox1OpenAnim");
	}
	public void PlayDeskBox1CloseAnim()
	{
		DeskBox1.GetComponent<Animation>().Play("DeskBox1CloseAnim");
	}

	public void PlayDeskBox2OpenAnim()
	{
		DeskBox2.GetComponent<Animation>().Play("DeskBox2OpenAnim");
	}
	public void PlayDeskBox2CloseAnim()
	{
		DeskBox2.GetComponent<Animation>().Play("DeskBox2CloseAnim");
	}

	public void PlayDeskBox3OpenAnim()
	{
		DeskBox3.GetComponent<Animation>().Play("DeskBox3OpenAnim");
	}
	public void PlayDeskBox3CloseAnim()
	{
		DeskBox3.GetComponent<Animation>().Play("DeskBox3CloseAnim");
	}

	public void PlayDeskBox4OpenAnim()
	{
		DeskBox4.GetComponent<Animation>().Play("DeskBox4OpenAnim");
	}
	public void PlayDeskBox4CloseAnim()
	{
		DeskBox4.GetComponent<Animation>().Play("DeskBox4CloseAnim");
	}

	public void PlayDeskBox5OpenAnim()
	{
		DeskBox5.GetComponent<Animation>().Play("DeskBox5OpenAnim");
	}
	public void PlayDeskBox5CloseAnim()
	{
		DeskBox5.GetComponent<Animation>().Play("DeskBox5CloseAnim");
	}

	public void PlayDeskBox6OpenAnim()
	{
		DeskBox6.GetComponent<Animation>().Play("DeskBox6OpenAnim");
	}
	public void PlayDeskBox6CloseAnim()
	{
		DeskBox6.GetComponent<Animation>().Play("DeskBox6CloseAnim");
	}

	public void PlayDeskBox7OpenAnim()
	{
		DeskBox7.GetComponent<Animation>().Play("DeskBox7OpenAnim");
	}
	public void PlayDeskBox7CloseAnim()
	{
		DeskBox7.GetComponent<Animation>().Play("DeskBox7CloseAnim");
	}

	public void PlayDeskBox8OpenAnim()
	{
		DeskBox8.GetComponent<Animation>().Play("DeskBox8OpenAnim");
	}
	public void PlayDeskBox8CloseAnim()
	{
		DeskBox8.GetComponent<Animation>().Play("DeskBox8CloseAnim");
	}

	public void PlayDeskBox9OpenAnim()
	{
		DeskBox9.GetComponent<Animation>().Play("DeskBox9OpenAnim");
	}
	public void PlayDeskBox9CloseAnim()
	{
		DeskBox9.GetComponent<Animation>().Play("DeskBox9CloseAnim");
	}

	public void PlayPictureFramePutDownAnim()
	{
		PictureFrame.GetComponent<Animation>().Play("PictureFramePutDownAnim");
	}

	public void PlaySuitcaseOpenAnim()
	{
		Suitcase.GetComponent<Animation>().Play("SuitcaseOpenAnim");
	}
	public void PlaySuitcaseCloseAnim()
	{
		Suitcase.GetComponent<Animation>().Play("SuitcaseCloseAnim");
	}

	public void PlayCreepyToyAnim()
	{
		CreepyToy.GetComponent<Animation>().Play("CreepyToyAnim");
	}

	public void PlayTeddyBearAnim()
	{
		TeddyBear.GetComponent<Animation>().Play("TeddyBearAnim");
	}
}
