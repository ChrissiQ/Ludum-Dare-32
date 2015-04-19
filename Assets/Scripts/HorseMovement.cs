using UnityEngine;
using System.Collections;

public class HorseMovement : MonoBehaviour {

	Animator anim;
	Rigidbody rb;
	GameObject target;
	public GameController gameController;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		anim.SetTrigger ("Walk");
		rb = GetComponent <Rigidbody> ();
	}

	void FixedUpdate () {
		if (target == null) {
			target = gameController.GetRandomFoliage();
			rb.transform.LookAt(target.transform);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == target.gameObject)
			Destroy(other.gameObject);
	}
}