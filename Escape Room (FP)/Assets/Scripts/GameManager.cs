using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public float IgnoreInputTime;

    public static bool ShowingTrashBin = false;
    public static bool ShowingSafe = false;
    public static bool ShowingDrw1 = false;
    public static bool ShowingDrw2 = false;
    public static bool ShowingDrw3 = false;
    public static bool ShowingDeskBox1 = false;
    public static bool ShowingDeskBox2 = false;
    public static bool ShowingDeskBox3 = false;
    public static bool ShowingDeskBox4 = false;
    public static bool ShowingDeskBox5 = false;
    public static bool ShowingDeskBox6 = false;
    public static bool ShowingDeskBox7 = false;
    public static bool ShowingDeskBox8 = false;
    public static bool ShowingDeskBox9 = false;
    public static bool ShowingSuitcase = false;
    public static bool ShowingDoor = false;

    public static bool GotLetterOpener = false;
    public static bool GotFork = false;
    public static bool GotLetter = false;
    public static bool GotGun = false;
    public static bool GotKey = false;

    public static GameManager GMInstance;
    private InputManager inputManager;


	void Awake()
    {
        QualitySettings.vSyncCount = 0; 
        Application.targetFrameRate = 144;

        GMInstance = this;
    }
	void Start()
	{
        inputManager = Player.GetComponent<InputManager>();
	}

    public void IgnoreInput()
	{
        inputManager.enabled = false;

        StartCoroutine(ReadInput());
	}
    IEnumerator ReadInput()
    {
        yield return new WaitForSeconds(IgnoreInputTime);

        inputManager.enabled = true;
    }

}
