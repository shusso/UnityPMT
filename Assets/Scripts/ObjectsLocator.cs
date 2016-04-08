using UnityEngine;
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

		public List<GameObject> FindObjectsFromLayer(Layers layer) {
			var foundObjects = new List<GameObject>();

			/* Lets do some expensive iterating yay */
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
			
		public List<GameObject> GetGameObjectsInRadius(Vector3 point, float radius) {
			
			Debug.Log("Finding Objects from Radius " + radius + " from position " + point.ToString());
			var allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject obj in allObjects) {
				
			}
			return foundGameObjects;
		}
	}
}