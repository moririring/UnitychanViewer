using UnityEngine;
using System.Collections;

public class unitychanFace : MonoBehaviour {

	private Animator anim;
	private int faceCount = 0;
	private string faceName = "POSE01";
	public float fadeTime = 3;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetLayerWeight (1, 1);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			anim.CrossFade("eye_close@unitychan", fadeTime);
		}


/*
		if ( GUI.Button( new Rect(10, 40, 100, 20), animName ) )
		{
			animCount = (animCount + 1) % 31;
			animName = string.Format("POSE{0:00}", animCount + 1);
			anim.CrossFade(animName, fadeTime);
		}
		*/
	}

}
