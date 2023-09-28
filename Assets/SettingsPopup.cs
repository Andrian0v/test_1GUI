using UnityEngine;
using System.Collections;
public class SettingsPopup : MonoBehaviour {
	public void Open() {
		gameObject.SetActive(true);
	}
	public void OnSubmitName(string name) 
	{
		Debug.Log(name);
	}
	public void OnSpeedValue(float speed) {
		Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
	}
	public void Close() {
		gameObject.SetActive(false);
	}
}
