using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	
	public int foliageCount;
	public GameObject foliage1;
	public GameObject foliage2;
	public GameObject foliageContainer;
	List<GameObject> foliage;
	float xsize = 50f;
	float zsize = 50f;

	void InstantiateRandom(List<GameObject> objectList, GameObject parentGameObject) {
		float x = Random.Range (0-xsize, xsize);
		float z = Random.Range (0-xsize, zsize);
		GameObject gameObject = (GameObject) Instantiate (
			objectList[Random.Range (0, objectList.Count)],
			new Vector3(x,0f,z),
			Quaternion.identity);
		gameObject.transform.parent = parentGameObject.transform;
	}

	void InstantiateFoliage () {
		InstantiateRandom (foliage, foliageContainer);
	}

	// Use this for initialization
	void Start () {
		foliage = new List<GameObject> () {foliage1, foliage2};
		for (int i=0; i<foliageCount; i++) {
			InstantiateFoliage();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
