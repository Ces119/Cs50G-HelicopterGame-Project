using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {

		// infinite coin spawning function, asynchronous
		StartCoroutine(SpawnGems());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnGems() {
		while (true) {

			// instantiate gem by some random amount of space
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-8, 8), 10), Quaternion.identity);

			// pause 1-5 seconds until the next gem spawns
			yield return new WaitForSeconds(Random.Range(8,10));
		}
	}
}
