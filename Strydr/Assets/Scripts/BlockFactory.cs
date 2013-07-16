using UnityEngine;
using System.Collections.Generic;

public class BlockFactory : MonoBehaviour {
	
	Dictionary<Vector2, GameObject> Blocks = new Dictionary<Vector2, GameObject>();
	
	public GameObject[] BlockLibrary; 
	
	public int levelWidth, levelHeight;
	
	// Use this for initialization
	void Start () {
		for (int x = 0; x < levelWidth; x++) {
			for (int y = 0; y < levelHeight; y++) {
				Instantiate((Object)BlockLibrary[0], new Vector3(x,y,0), Quaternion.identity);
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
