using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace weapons
{
	using UnityEngine;
	public static class WeaponTypes {
		private static int size = 15;
		/* This holds all different Weapons we have */
		public static List<ProjectileBase> projectiles = new List<ProjectileBase>(size);
		public static Dictionary<string, ProjectileBase> weapons = new Dictionary<string, ProjectileBase>(size);

		public static void addProjectile(ProjectileBase p){
			if (!projectiles.Any(i => i.GetType() == p.GetType())) {
				Debug.Log("Adding instance of " + p.transform.name.ToString());
				projectiles.Add(p);
			} 
			
			if (!weapons.ContainsKey(p.transform.name)) {
				Debug.Log("Adding new instance to dict " + p.transform.ToString());
				weapons.Add(p.transform.name, p);
			}
		}
	}

	public abstract class ProjectileBase : MonoBehaviour {
		private Vector3 velocity;
		[SerializeField]
		private float speed;
		[SerializeField]
		private float damage;
		[SerializeField]
		private float damageRadius;

//		protected ProjectileBase(ProjectileBase p) {WeaponTypes.addProjectile(p); }

		protected void addNewWeaponType(){
			WeaponTypes.addProjectile(this);
		}
		protected Vector3 getVelocity() {
			return velocity;
		}
		protected Rigidbody getRigidbody() {
			return gameObject.GetComponent<Rigidbody>();
		}
		protected void applyForce(Vector3 force) {
			getRigidbody().AddForce(force);
		}
			
		public abstract void Update();
		public abstract void Start();			
		public abstract void FixedUpdate();
	}

}