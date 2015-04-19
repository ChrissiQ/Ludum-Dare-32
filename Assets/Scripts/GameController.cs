using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	
	public int foliageCount;
	public GameObject foliage1;
	public GameObject foliage2;
	public GameObject foliageContainer;
	public float xsize = 50f;
	public float zsize = 50f;

	List<GameObject> foliage;

	public GameObject GetRandomFoliage () {
		return foliageContainer.transform.GetChild (Random.Range (0, foliageContainer.transform.childCount-1)).gameObject;
	}

	void InstantiateRandom() {
		float x = Random.Range (0-xsize, xsize);
		float z = Random.Range (0-xsize, zsize);
		GameObject gameObject = (GameObject) Instantiate (
			foliage[Random.Range (0, foliage.Count-1)],
			new Vector3 (x, 0f, z),
			Quaternion.identity);
		gameObject.transform.parent = foliageContainer.transform;
	}

	void InstantiateFoliage () {
		InstantiateRandom ();
	}

	// Use this for initialization
	void Start () {
		foliage = new List<GameObject> () {foliage1, foliage2};
		for (int i = 0; i < foliageCount; i++) {
			InstantiateFoliage();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
