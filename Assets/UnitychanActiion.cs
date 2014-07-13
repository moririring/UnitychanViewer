using UnityEngine;
using System.Collections;

public class UnitychanActiion : MonoBehaviour {

	private Animator anim;
	private int animCount = 0;
	private string animName = "WAIT00";
	public float fadeTime = 3;
	static readonly string[] faceNames = 
	{
		"WAIT00",
		"WAIT01",
		"WAIT02",
		"WAIT03",
		"WAIT04",
		"WALK00_B",
		"WALK00_F",
		"WALK00_L",
		"WALK00_R",
		"WIN00",
		"LOSE00",
		"DAMAGED00",
		"DAMAGED01",
		"REFLESH00",
		"JUMP00B",
		"JUMP01B",
		"HANDUP00_R",
		"JUMP00",
		"JUMP01",
		"RUN00_F",
		"RUN00_L",
		"RUN00_R",
		"SLIDE00",
		"UMATOBI00",
	};


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI()
	{
		if ( GUI.Button( new Rect(10, 100, 100, 20), animName ) )
		{
			var go = GameObject.Find("Main Camera").GetComponent<Transform> ();
			go.position = new Vector3 (0, 2.0f, 1.0f);
			
			anim.runtimeAnimatorController = Resources.Load ("Animators/UnityChanActionCheck") as RuntimeAnimatorController;
			
			animName = faceNames[animCount];
			anim.CrossFade(animName, fadeTime);
			animCount = (animCount + 1) % faceNames.Length;
		}
	}
}
