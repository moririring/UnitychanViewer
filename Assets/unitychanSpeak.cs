using UnityEngine;
using System.Collections;
using System.Linq;

public class unitychanSpeak : MonoBehaviour {

	public AudioClip selectSound;
	private int soundCount = 1;
	private string soundName = "univ0001";

	// Use this for initialization
	void Start () {
		audio.clip = selectSound;
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI()
	{
		if ( GUI.Button( new Rect(10, 10, 100, 20), soundName ) )
		{
			while(true)
			{
				soundCount = (soundCount + 1) % (1343 + 1);
				soundName = string.Format("univ{0:0000}", soundCount);
				audio.clip = Resources.Load("Voice/" + soundName) as AudioClip;
				if(audio.clip != null) break;
			}
			audio.Play();
		}
	}
}
