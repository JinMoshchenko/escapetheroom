using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
	private CameraManager cameraManager;
	private UIManager uiManager;
	private AnimationManager animationManager;
	private SoundManager soundManager;
	private GameManager gameManager;
	private RaycastHit hit;
	private Ray ray;

	[Header("Items")]
	public GameObject Fork;
	public GameObject LetterOpener;
	public GameObject Letter;
	public GameObject Gun;
	public GameObject Key;
	[Header("Main objects")]
	public BoxCollider Safe;
	public BoxCollider TrashBin;
	public BoxCollider Drw1;
	public BoxCollider Drw2;
	public BoxCollider Drw3;
	public BoxCollider DeskBox1;
	public BoxCollider DeskBox2;
	public BoxCollider DeskBox3;
	public BoxCollider DeskBox4;
	public BoxCollider DeskBox5;
	public BoxCollider DeskBox6;
	public BoxCollider DeskBox7;
	public BoxCollider DeskBox8;
	public BoxCollider DeskBox9;
	public BoxCollider PictureFrame;
	public BoxCollider Suitcase;



	void Start()
	{
		cameraManager = CameraManager.CMInstance;
		uiManager = UIManager.UIMInstance;
		animationManager = AnimationManager.AMInstance;
		soundManager = SoundManager.SMInstance;
		gameManager = GameManager.GMInstance;
	}

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.D))
		{
			cameraManager.UpdateCameraByD();
			gameManager.IgnoreInput();
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			cameraManager.UpdateCameraByA();
			gameManager.IgnoreInput();
		}


		if(Input.GetKeyDown(KeyCode.Tab))
		{
			uiManager.ManageControlsUI();
		}


		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "Safe")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToSafe();

					if(GameManager.GotLetter == true)
					{
					    animationManager.PlaySafeOpenAnim();
						if(Gun != null)
						{
							Gun.GetComponent<BoxCollider>().enabled = true;
						}
					}
					else
					{
						uiManager.ShowInfoText(3);
						soundManager.PlaySoundLocked();
					}

					Safe.enabled = false;
					GameManager.ShowingSafe = true;
				}
				else if(hit.collider.tag == "Bed")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToBed();

					uiManager.ShowInfoText(8);
				}
				else if (hit.collider.tag == "Door")
				{
					gameManager.IgnoreInput();
					if (GameManager.GotKey == true && transform.position == cameraManager.CamPositions[1].position)
					{
						soundManager.PlaySoundDoorOpen();
						animationManager.PlayDoorOpenAnim();
						StartCoroutine(EndGame());
					}
					else
					{
						soundManager.PlaySoundDoorLocked();
						animationManager.PlayDoorAnim();
						uiManager.ShowInfoText(3);
					}
				}
				else if (hit.collider.tag == "Drw 1")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDrw1 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDrw1OpenAnim();
					cameraManager.SetCameraToDrw1();

					Drw1.enabled = false;
				}
				else if (hit.collider.tag == "Drw 2")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDrw2 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDrw2OpenAnim();
					cameraManager.SetCameraToDrw2();

					uiManager.ShowInfoText(2);

					Drw2.enabled = false;
				}
				else if (hit.collider.tag == "Drw 3")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDrw3 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDrw3OpenAnim();
					cameraManager.SetCameraToDrw3();

					Drw3.enabled = false;
				}
				else if (hit.collider.tag == "Table")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToTable();
				}
				else if(hit.collider.tag == "Trash bin")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingTrashBin = true;

					animationManager.PlayTrashBinOpenAnim();
					cameraManager.SetCameraToTrashbin();

					uiManager.ShowInfoText(4);

					TrashBin.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox1")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox1 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox1OpenAnim();
					cameraManager.SetCameraToDeskBox1();

					DeskBox1.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox2")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox2 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox2OpenAnim();
					cameraManager.SetCameraToDeskBox2();

					DeskBox2.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox3")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox3 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox3OpenAnim();
					cameraManager.SetCameraToDeskBox3();

					DeskBox3.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox4")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox4 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox4OpenAnim();
					cameraManager.SetCameraToDeskBox4();

					uiManager.ShowInfoText(2);

					DeskBox4.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox5")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox5 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox5OpenAnim();
					cameraManager.SetCameraToDeskBox5();

					DeskBox5.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox6")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox6 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox6OpenAnim();
					cameraManager.SetCameraToDeskBox6();

					DeskBox6.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox7")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox7 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox7OpenAnim();
					cameraManager.SetCameraToDeskBox7();

					uiManager.ShowInfoText(4);

					DeskBox7.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox8")
				{
					gameManager.IgnoreInput();
					GameManager.ShowingDeskBox8 = true;

					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox8OpenAnim();
					cameraManager.SetCameraToDeskBox8();

					DeskBox8.enabled = false;
				}
				else if (hit.collider.tag == "DeskBox9")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToDeskBox9();
					
					if(GameManager.GotGun == true)
					{
						soundManager.PlaySoundDrawerOpenClose();
						animationManager.PlayDeskBox9OpenAnim();
						if(Key != null)
						{
							Key.GetComponent<BoxCollider>().enabled = true;
						}
					}
					else
					{
						soundManager.PlaySoundLocked();
						uiManager.ShowInfoText(3);
					}

					DeskBox9.enabled = false;
					GameManager.ShowingDeskBox9 = true;
				}
				else if (hit.collider.tag == "PictureFrame")
				{
					gameManager.IgnoreInput();
					animationManager.PlayPictureFramePutDownAnim();
					cameraManager.SetCameraToPictureFrame();

					PictureFrame.enabled = false;
					LetterOpener.GetComponent<BoxCollider>().enabled = true;
				}
				else if (hit.collider.tag == "Suitcase")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToSuitcase();

					if (GameManager.GotFork == true)
					{
						animationManager.PlaySuitcaseOpenAnim();
						if(Letter != null)
						{
							Letter.GetComponent<BoxCollider>().enabled = true;
						}
					}
					else
					{
						soundManager.PlaySoundLocked();
						uiManager.ShowInfoText(3);
					}

					Suitcase.enabled = false;
					GameManager.ShowingSuitcase = true;
				}
				else if (hit.collider.tag == "Gun")
				{
					Destroy(Gun);
					uiManager.Gun.SetActive(true);
					GameManager.GotGun = true;

					soundManager.PlaySoundGotItem();
					uiManager.ShowInfoText(1);
				}
				else if (hit.collider.tag == "Board")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToBoard();
				}
				else if(hit.collider.tag == "Clock")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToClock();
				}
				else if (hit.collider.tag == "CreepyToy")
				{
					gameManager.IgnoreInput();
					animationManager.PlayCreepyToyAnim();

					uiManager.ShowInfoText(5);
				}
				else if (hit.collider.tag == "Lamp")
				{
					animationManager.LampOff();
					soundManager.PlaySoundLightSwitch();

					uiManager.ShowInfoText(6);
				}
				else if (hit.collider.tag == "Letter")
				{
					Destroy(Letter);
					uiManager.Letter.SetActive(true);
					GameManager.GotLetter = true;
					soundManager.PlaySoundGotItem();
					uiManager.ShowInfoText(1);
				}
				else if (hit.collider.tag == "DVRPlayer")
				{
					if(uiManager.TvPic.activeSelf == true)
					{
						uiManager.TvPic.SetActive(false);
					}
					uiManager.DVRPic.SetActive(true);

					soundManager.PlaySoundDVR();
					uiManager.ShowInfoText(7);
				}
				else if (hit.collider.tag == "Remote")
				{
					if (uiManager.DVRPic.activeSelf == true)
					{
						uiManager.DVRPic.SetActive(false);
					}
					uiManager.TvPic.SetActive(true);
				}
				else if (hit.collider.tag == "Poster")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToPoster();

					uiManager.ShowInfoText(5);
				}
				else if (hit.collider.tag == "Chair 1")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToChair1();
				}
				else if (hit.collider.tag == "Chair 2")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToChair2();
				}
				else if (hit.collider.tag == "LetterOpener")
				{
					Destroy(LetterOpener);
					uiManager.LetterOpener.SetActive(true);
					GameManager.GotLetterOpener = true;

					soundManager.PlaySoundGotItem();
					uiManager.ShowInfoText(1);
				}
				else if (hit.collider.tag == "TeddyBear")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToTeddyBear();

					if (GameManager.GotLetterOpener == true)
					{
						soundManager.PlaySoundBearTear();
					    animationManager.PlayTeddyBearAnim();
						StartCoroutine(DestroyTeddy());
					}
					else
					{
						uiManager.ShowInfoText(2);
					}
				}
				else if (hit.collider.tag == "Fork")
				{
					Destroy(Fork);
					uiManager.Fork.SetActive(true);
					GameManager.GotFork = true;

					soundManager.PlaySoundGotItem();
					uiManager.ShowInfoText(1);
				}
				else if (hit.collider.tag == "Key")
				{
					Destroy(Key);
					uiManager.Key.SetActive(true);
					GameManager.GotKey = true;

					soundManager.PlaySoundGotItem();
					uiManager.ShowInfoText(1);
				}
				else if (hit.collider.tag == "Books 1")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToBooks1();
				}
				else if (hit.collider.tag == "Books 2")
				{
					gameManager.IgnoreInput();
					cameraManager.SetCameraToBooks2();
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			if(GameManager.ShowingTrashBin == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingTrashBin = false;

				animationManager.PlayTrashBinCloseAnim();
				cameraManager.UpdateCameraByMouse1();

				TrashBin.enabled = true;
			}
			else if(GameManager.ShowingSafe == true)
			{
				gameManager.IgnoreInput();
				if (GameManager.GotLetter==true)
				{
					animationManager.PlaySafeCloseAnim();
				}

				cameraManager.UpdateCameraByMouse1();
				GameManager.ShowingSafe = false;
				Safe.enabled = true;
			}
			else if(GameManager.ShowingDrw1 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDrw1 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDrw1CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				Drw1.enabled = true;
			}
			else if (GameManager.ShowingDrw2 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDrw2 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDrw2CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				Drw2.enabled = true;
			}
			else if (GameManager.ShowingDrw3 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDrw3 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDrw3CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				Drw3.enabled = true;
			}
			else if (GameManager.ShowingDeskBox1 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox1 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox1CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox1.enabled = true;
			}
			else if (GameManager.ShowingDeskBox2 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox2 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox2CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox2.enabled = true;
			}
			else if (GameManager.ShowingDeskBox3 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox3 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox3CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox3.enabled = true;
			}
			else if (GameManager.ShowingDeskBox4 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox4 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox4CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox4.enabled = true;
			}
			else if (GameManager.ShowingDeskBox5 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox5 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox5CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox5.enabled = true;
			}
			else if (GameManager.ShowingDeskBox6 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox6 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox6CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox6.enabled = true;
			}
			else if (GameManager.ShowingDeskBox7 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox7 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox7CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox7.enabled = true;
			}
			else if (GameManager.ShowingDeskBox8 == true)
			{
				gameManager.IgnoreInput();
				GameManager.ShowingDeskBox8 = false;

				soundManager.PlaySoundDrawerOpenClose();
				animationManager.PlayDeskBox8CloseAnim();
				cameraManager.UpdateCameraByMouse1();

				DeskBox8.enabled = true;
			}
			else if (GameManager.ShowingDeskBox9 == true)
			{
				gameManager.IgnoreInput();
				if (GameManager.GotGun == true)
				{
					soundManager.PlaySoundDrawerOpenClose();
					animationManager.PlayDeskBox9CloseAnim();
				}
				
				cameraManager.UpdateCameraByMouse1();
				GameManager.ShowingDeskBox9 = false;
				DeskBox9.enabled = true;
			}
			else if (GameManager.ShowingSuitcase == true)
			{
				gameManager.IgnoreInput();
				if (GameManager.GotFork == true)
				{
					animationManager.PlaySuitcaseCloseAnim();
				}

				cameraManager.UpdateCameraByMouse1();
				GameManager.ShowingSuitcase = false;
				Suitcase.enabled = true;
			}
			else if (animationManager.Darkness.activeSelf != false)
			{
				soundManager.PlaySoundLightSwitch();
				animationManager.LampOn();
			}
			else
			{
				gameManager.IgnoreInput();
				cameraManager.UpdateCameraByMouse1();
			}
		}

		IEnumerator DestroyTeddy()
		{
			yield return new WaitForSeconds(2.5f);

			Destroy(animationManager.TeddyBear);
			Fork.GetComponent<BoxCollider>().enabled = true;
			Fork.GetComponent<Rigidbody>().isKinematic = false;
		}
		IEnumerator EndGame()
		{
			yield return new WaitForSeconds(1.2f);
			SceneManager.LoadScene(2);
		}
	}
}
