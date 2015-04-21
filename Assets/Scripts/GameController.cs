using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	
	public int foliageCount;
	public List<GameObject> foliage;
	public GameObject foliageContainer;
	public float xsize = 25f;
	public float zsize = 25f;
	public Text gameOver;
	bool dead;

	public GameObject GetRandomFoliage () {
		return foliageContainer.transform.GetChild (Random.Range (0, foliageContainer.transform.childCount)).gameObject;
	}

	public void Die() {
		dead = true;
	}

	void InstantiateRandom() {
		float x = Random.Range (0-xsize, xsize);
		float z = Random.Range (0-xsize, zsize);

		GameObject gameObject = (GameObject) Instantiate (
			foliage[Random.Range (0, foliage.Count)],
			new Vector3 (x, 0f, z),
			Quaternion.identity);
		gameObject.transform.parent = foliageContainer.transform;
	}

	void InstantiateFoliage () {
		for (int i = 0; i < foliageCount; i++)
			InstantiateRandom ();
	}

	// Use this for initialization
	void Start () {
		InstantiateFoliage ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		if (dead) {
			gameOver.enabled = true;
		}
	}
}
