using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour 
{
	
	private Animator anim;
	public Vector3 targetDirection;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		targetDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
		if (targetDirection.magnitude > 0.1) {
			anim.SetBool ("Walk", true);
			transform.rotation = Quaternion.LookRotation(targetDirection);
			CharacterController conroller = GetComponent<CharacterController>();
			conroller.Move(transform.forward * Time.deltaTime * 3f);
		} else {
			anim.SetBool ("Walk", false);
		}
	}
}
