using UnityEngine;
using System.Collections;
using weapons;
using Locator;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private int enemyZValue = 100;

	public GameObject cannonPrefab;

	public Vector3 velocity = new Vector3(0, 0, 400);

	private ObjectsLocator locator = new ObjectsLocator();

	void Start() {
		locator.GetGameObjectsInRadius(transform.position, 1.0f);
		locator.FindObjectsFromLayer(Locator.Layers.UI);
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
//			print("mouse pressed " +Input.mousePosition.ToString());

			var l = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y, enemyZValue);


			var s = Camera.main.ScreenToWorldPoint(l);
			var cannon = Instantiate(cannonPrefab, s, Quaternion.identity) as GameObject;
			cannon.GetComponent<Rigidbody>().AddForce(velocity);
			Destroy(cannon, 12.0f);
		}
		
	}
}
