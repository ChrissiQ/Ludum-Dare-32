using UnityEngine;
using System.Collections;

public class HorseMovement : MonoBehaviour {
	
	public GameController gameController;
	public float waitBetweenTargets;
	public AudioSource panicMusic;

	Animator anim;
	Rigidbody rb;
	GameObject target;
	float lastEaten;
	AudioSource backgroundMusic;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		rb = GetComponent <Rigidbody> ();
		lastEaten = Time.time;
		backgroundMusic = gameController.GetComponent <AudioSource> ();
		backgroundMusic.Play();
	}

	void FixedUpdate () {

		if (Time.time - lastEaten < waitBetweenTargets) {
			anim.SetBool("isWalking", false);

		} else if (target == null) {
			target = gameController.GetRandomFoliage();
			rb.transform.LookAt(target.transform);
			anim.SetBool("isWalking", true);
			if (target.CompareTag("MainCharacter")) {
				backgroundMusic.Stop();
				panicMusic.Play();
			} else {
				backgroundMusic.Play();
				panicMusic.Stop();
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (target != null && other.gameObject == target.gameObject) {
			lastEaten = Time.time;
			if (other.CompareTag("MainCharacter")) {
				gameController.Die();
			}
			Destroy(other.gameObject);
		}
	}
}