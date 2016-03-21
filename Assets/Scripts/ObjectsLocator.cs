using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Returns All GameObjects within given radius
 */
public class ObjectsLocator {
	private List<GameObject> foundGameObjects = new List<GameObject>();

	private GameObject[] getRootGameObjects() {
		return SceneManager.GetActiveScene().GetRootGameObjects();
	}
		
	public List<GameObject> getGameObjects(float radius) {
		return foundGameObjects;
	}

}
