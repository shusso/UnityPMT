using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Locator 
{
public enum Layers {
		Default=0,
		TransparentFX,
		IgnoreRaycast,
		Water = 4,
		UI = 5 }

	/* Returns All GameObjects within given radius
	 */
	public class ObjectsLocator {
		private List<GameObject> foundGameObjects = new List<GameObject>();

		private GameObject[] getRootGameObjects() {
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}

		public List<GameObject> FindObjectsFromLayer(Layers layer) {
			var foundObjects = new List<GameObject>();
			var allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

			foreach (GameObject obj in allObjects) {
				if ((Layers)obj.layer == layer) {
					Debug.Log("Layer: " + Layers.UI.ToString() + " has object: " +obj.name);
					foundObjects.Add(obj);
				}
			}
			Debug.Log("Found "+ foundObjects.Count + " objects from Layer: " + layer.ToString());

			return foundObjects;
		}
			
		public List<GameObject> GetGameObjects(float radius) {
			var e = getRootGameObjects() as GameObject[];
			Debug.Log(e.ToList().ToString());

			var allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject g in allObjects) {
			}

			return foundGameObjects;
		}
	}
}