using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using weapons;

namespace BaseEnemy 
{	
	public abstract class EnemyBase : MonoBehaviour {
		[SerializeField]
		private float baseHealth;
		private float currentHealth;
		[SerializeField]
		private float speed;
		[SerializeField]
		private Vector3 velocity;

		public EnemyBase() {
			currentHealth = baseHealth;
		}

		protected Vector3 getVelocity() {
			return velocity;
		}
		protected void setVelocity(Vector3 v) {
			velocity = v;
		}
		protected void applyForce(Vector3 f) {
			gameObject.GetComponent<Rigidbody>().AddForce(f);
		}
		protected float getHealth(){
			return currentHealth;
		}
		protected void addHealth(float amount) {
			currentHealth += amount;
		}
		protected void removeHealth(float amount) {
			currentHealth -= amount;
			if (currentHealth <= 0) {
				kill();
			}
		}
		protected void heal() {
			currentHealth = baseHealth;
		}
		private void kill() {
			Destroy(this);
		}

		public abstract void Update();
		public abstract void Start();
		public abstract void FixedUpdate();


		public void OnCollisionEnter(Collision collision) {
			//TODO check what weapon fired us and remove health
			print("/// Collision Enter ///");
			
			
		}
	}
}