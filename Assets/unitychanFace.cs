using UnityEngine;
using System.Collections;

public class unitychanFace : MonoBehaviour {

	private Animator anim;
	private int faceCount;
	private string faceName;
	public float fadeTime = 3;
	static readonly string[] faceNames = 
	{
		"angry1",
		"angry2",
		"conf",
		"default",
		"disstract1",
		"disstract2",
		"eye_close",
		"sap",
		"smile1",
		"smile2",
	};

	void FaceChange()
	{
		var go = GameObject.Find("Main Camera").GetComponent<Transform> ();
		var head = GameObject.Find("Character1_Head").GetComponent<Transform> ();
		go.position = new Vector3 (0, 0, 0.7f) + head.position;
		anim.SetLayerWeight (1, 1);

		faceName = faceNames[faceCount];
		anim.CrossFade(faceName + "@unitychan", fadeTime);
		faceCount = (faceCount + 1) % faceNames.Length;
	}

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		FaceChange();



	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI()
	{
		if ( GUI.Button( new Rect(10, 70, 100, 20), faceName ) )
		{
			FaceChange();
		}
	}
}