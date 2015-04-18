using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Transform foliage;

	// Use this for initialization
	void Start () {
		Instantiate (foliage, new Vector3(1f,0f,3f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
