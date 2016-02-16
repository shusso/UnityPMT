using UnityEngine;
using System.Collections;
using weapons;

public class Player : MonoBehaviour {
	public GameObject cannonPrefab;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			print("mouse pressed");
			var s = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			var cannon = Instantiate(cannonPrefab, s, Quaternion.identity);

		}
		
	}
}
