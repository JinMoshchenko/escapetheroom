using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	public Transform[] CamPositions;
	public GameObject Darkness;

	[Header("Main Objects Positions")]
	public Transform CamTrashBin;
	public Transform CamTeddyBear;
	public Transform CamSafe;
	public Transform CamDrw1;
	public Transform CamDrw2;
	public Transform CamDrw3;
	public Transform CamDeskBox1;
	public Transform CamDeskBox2;
	public Transform CamDeskBox3;
	public Transform CamDeskBox4;
	public Transform CamDeskBox5;
	public Transform CamDeskBox6;
	public Transform CamDeskBox7;
	public Transform CamDeskBox8;
	public Transform CamDeskBox9;
	public Transform CamPictureFrame;
	public Transform CamSuitcase;
	public Transform CamClock;

	[Header("Regular Objects Positions")]
	public Transform CamBed;
	public Transform CamTable;
	public Transform CamBoard;
	public Transform CamPoster;
	public Transform CamChair1;
	public Transform CamChair2;
	public Transform CamBooks1;
	public Transform CamBooks2;

	public float RepositionTime;
	public static CameraManager CMInstance;


	private int positionIndex = 0;

	private void Awake()
	{
		CMInstance = this;
	}

	public void UpdateCameraByD()
	{
		positionIndex++;

		if (Darkness.activeSelf != true)
		{
			if (positionIndex != CamPositions.Length)
			{
				LeanTween.move(gameObject, CamPositions[positionIndex].position, RepositionTime);
				LeanTween.rotate(gameObject, CamPositions[positionIndex].rotation.eulerAngles, RepositionTime);
			}
			else
			{
				positionIndex = 0;
				LeanTween.move(gameObject, CamPositions[positionIndex].position, RepositionTime);
				LeanTween.rotate(gameObject, CamPositions[positionIndex].rotation.eulerAngles, RepositionTime);
			}
		}
	}

	public void UpdateCameraByA()
	{
		positionIndex--;

		if (Darkness.activeSelf != true)
		{
			if (positionIndex < 0)
			{
				positionIndex = CamPositions.Length - 1;
				LeanTween.move(gameObject, CamPositions[positionIndex].position, RepositionTime);
				LeanTween.rotate(gameObject, CamPositions[positionIndex].rotation.eulerAngles, RepositionTime);
			}
			else
			{
				LeanTween.move(gameObject, CamPositions[positionIndex].position, RepositionTime);
				LeanTween.rotate(gameObject, CamPositions[positionIndex].rotation.eulerAngles, RepositionTime);
			}
		}
	}

	public void UpdateCameraByMouse1()
	{
		if (Darkness.activeSelf != true)
		{
			LeanTween.move(gameObject, CamPositions[positionIndex].position, RepositionTime);
			LeanTween.rotate(gameObject, CamPositions[positionIndex].rotation.eulerAngles, RepositionTime);
		}
	}

	#region ObjectsCams
	//Main objects
	public void SetCameraToTrashbin()
	{
		LeanTween.move(gameObject, CamTrashBin.position, RepositionTime);
		LeanTween.rotate(gameObject, CamTrashBin.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToTeddyBear()
	{
		LeanTween.move(gameObject, CamTeddyBear.position, RepositionTime);
		LeanTween.rotate(gameObject, CamTeddyBear.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToSafe()
	{
		LeanTween.move(gameObject, CamSafe.position, RepositionTime);
		LeanTween.rotate(gameObject, CamSafe.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDrw1()
	{
		LeanTween.move(gameObject, CamDrw1.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDrw1.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDrw2()
	{
		LeanTween.move(gameObject, CamDrw2.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDrw2.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDrw3()
	{
		LeanTween.move(gameObject, CamDrw3.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDrw3.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox1()
	{
		LeanTween.move(gameObject, CamDeskBox1.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox1.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox2()
	{
		LeanTween.move(gameObject, CamDeskBox2.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox2.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox3()
	{
		LeanTween.move(gameObject, CamDeskBox3.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox3.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox4()
	{
		LeanTween.move(gameObject, CamDeskBox4.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox4.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox5()
	{
		LeanTween.move(gameObject, CamDeskBox5.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox5.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox6()
	{
		LeanTween.move(gameObject, CamDeskBox6.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox6.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox7()
	{
		LeanTween.move(gameObject, CamDeskBox7.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox7.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox8()
	{
		LeanTween.move(gameObject, CamDeskBox8.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox8.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToDeskBox9()
	{
		LeanTween.move(gameObject, CamDeskBox9.position, RepositionTime);
		LeanTween.rotate(gameObject, CamDeskBox9.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToPictureFrame()
	{
		LeanTween.move(gameObject, CamPictureFrame.position, RepositionTime);
		LeanTween.rotate(gameObject, CamPictureFrame.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToSuitcase()
	{
		LeanTween.move(gameObject, CamSuitcase.position, RepositionTime);
		LeanTween.rotate(gameObject, CamSuitcase.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToClock()
	{
		LeanTween.move(gameObject, CamClock.position, RepositionTime);
		LeanTween.rotate(gameObject, CamClock.rotation.eulerAngles, RepositionTime);
	}


	//Regular objects
	public void SetCameraToBed()
	{
		LeanTween.move(gameObject, CamBed.position, RepositionTime);
		LeanTween.rotate(gameObject, CamBed.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToTable()
	{
		LeanTween.move(gameObject, CamTable.position, RepositionTime);
		LeanTween.rotate(gameObject, CamTable.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToBoard()
	{
		LeanTween.move(gameObject, CamBoard.position, RepositionTime);
		LeanTween.rotate(gameObject, CamBoard.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToPoster()
	{
		LeanTween.move(gameObject, CamPoster.position, RepositionTime);
		LeanTween.rotate(gameObject, CamPoster.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToChair1()
	{
		LeanTween.move(gameObject, CamChair1.position, RepositionTime);
		LeanTween.rotate(gameObject, CamChair1.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToChair2()
	{
		LeanTween.move(gameObject, CamChair2.position, RepositionTime);
		LeanTween.rotate(gameObject, CamChair2.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToBooks1()
	{
		LeanTween.move(gameObject, CamBooks1.position, RepositionTime);
		LeanTween.rotate(gameObject, CamBooks1.rotation.eulerAngles, RepositionTime);
	}
	public void SetCameraToBooks2()
	{
		LeanTween.move(gameObject, CamBooks2.position, RepositionTime);
		LeanTween.rotate(gameObject, CamBooks2.rotation.eulerAngles, RepositionTime);
	}

	#endregion
}
