using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	
	public int foliageCount;
	public Transform foliage1;
	public Transform foliage2;
	List<Transform> foliage;
	float xsize = 50f;
	float zsize = 50f;

	void InstantiateRandom(List<Transform> transList) {
		float x = Random.Range (0-xsize, xsize);
		float z = Random.Range (0-xsize, zsize);
		Transform trans = transList[Random.Range (0, transList.Count)];
		Instantiate (trans, new Vector3(x,0f,z), Quaternion.identity);
	}

	void InstantiateFoliage () {
		InstantiateRandom (foliage);
	}

	// Use this for initialization
	void Start () {
		foliage = new List<Transform> () {foliage1, foliage2};
		for (int i=0; i<foliageCount; i++) {
			InstantiateFoliage();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
