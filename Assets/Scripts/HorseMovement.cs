using UnityEngine;
using System.Collections;

public class HorseMovement : MonoBehaviour {

	Animator anim;
	Rigidbody rb;
	Transform trans;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		anim.SetTrigger ("Walk");
	}
}