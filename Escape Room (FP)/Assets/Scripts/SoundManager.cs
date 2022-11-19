using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource GotItem;
    public AudioSource DVR;
    public AudioSource DrawerOpenClose;
    public AudioSource DoorLocked;
    public AudioSource DoorOpen;
    public AudioSource BearTear;
    public AudioSource LightSwitch;
    public AudioSource Locked;

    public static SoundManager SMInstance;

	private void Awake()
	{
        SMInstance = this;
    }


	public void PlaySoundGotItem()
	{
        GotItem.Play();
	}
    public void PlaySoundDVR()
    {
        DVR.Play();
    }
    public void PlaySoundDrawerOpenClose()
    {
        DrawerOpenClose.Play();
    }
    public void PlaySoundDoorLocked()
    {
        DoorLocked.Play();
    }
    public void PlaySoundDoorOpen()
    {
        DoorOpen.Play();
    }
    public void PlaySoundBearTear()
    {
        BearTear.Play();
    }
    public void PlaySoundLightSwitch()
    {
        LightSwitch.Play();
    }
    public void PlaySoundLocked()
    {
        Locked.Play();
    }
}
