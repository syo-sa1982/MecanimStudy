using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {
	
	private Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("up")) {
			anim.SetBool ("Walk", true);
		} else {
			anim.SetBool ("Walk", false);
		}
	}
}
