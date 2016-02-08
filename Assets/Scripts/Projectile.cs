using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace weapons
{
	public static class WeaponTypes {
		private static int size = 15;
		/* This holds all different Weapons we have */
		public static List<Projectile> projectiles = new List<Projectile>(size);
		public static Dictionary<string, Projectile> weapons = new Dictionary<string, Projectile>(size);
	}

	public abstract class Projectile : MonoBehaviour {
		private Vector3 velocity;
		[SerializeField]
		private float speed;
		[SerializeField]
		private float damage;
		[SerializeField]
		private float damageRadius;

		protected void addWT(){
			print("/// added Projectile to WeaponTypes ////");
			print(this.transform.name.ToString());
			WeaponTypes.projectiles.Add(this);
			WeaponTypes.weapons.Add(this.transform.name, this);
			print(WeaponTypes.projectiles.Count);
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