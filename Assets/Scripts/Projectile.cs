using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace weapons
{
	public static class WeaponTypes {
		/* This holds all different Weapons we have */
		public static List<Projectile> projectiles;
		public static Dictionary<string, Projectile> weapons;
	}

	public abstract class Projectile : MonoBehaviour {
		[SerializeField]
		private Vector3 velocity;
		[SerializeField]
		private float speed;
		[SerializeField]
		private float damage;
		[SerializeField]
		private float damageRadius;

		public Projectile() {
			WeaponTypes.projectiles.Add(this);
			WeaponTypes.weapons.Add(this.transform.name, this);
		}
	
		private Rigidbody getRigidbody() {
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