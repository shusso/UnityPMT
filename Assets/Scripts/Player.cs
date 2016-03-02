using UnityEngine;
using System.Collections;
using weapons;

public class Player : MonoBehaviour {
	public GameObject cannonPrefab;

	Vector3 velocity = new Vector3(0, 0, 400);

	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			print("mouse pressed " +Input.mousePosition.ToString());

			var l = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y, 8);
			
			var s = Camera.main.ScreenToWorldPoint(l);
			var cannon = Instantiate(cannonPrefab, s, Quaternion.identity) as GameObject;
			cannon.GetComponent<Rigidbody>().AddForce(velocity);
			Destroy(cannon, 6.0f);
		}
		
	}
}
