using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Locator 
{
	/* Returns All GameObjects within given radius
	 */
	public class ObjectsLocator {
		enum Layers {Default=0,
					TransparentFX,
					IgnoreRaycast,
					Water = 4,
					UI = 5}

		private List<GameObject> foundGameObjects = new List<GameObject>();

		private GameObject[] getRootGameObjects() {
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}

		public List<GameObject> FindObjectsFromLayer(string layerName) {
			var foundObjects = new List<GameObject>();
			var allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

			foreach (GameObject g in allObjects) {
				Debug.Log("Current layers: " + Layers.UI);
				if(g.layer.ToString() == layerName) {
					Debug.Log(g.name);
				}
			}

			return foundObjects;
		}
			
		public List<GameObject> GetGameObjects(float radius) {

			var e = getRootGameObjects() as GameObject[];
			Debug.Log("========= GameObjects");
			Debug.Log(e.ToList().ToString());

			var allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject g in allObjects) {
				Debug.Log(g.name);
			}

			return foundGameObjects;
		}
	}
}