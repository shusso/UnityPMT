using UnityEngine;
using System.Collections;
using weapons;

public class CannonProjectile : ProjectileBase {
	public void Awake() {
		addNewWeaponType();
	}
		
	public override void Start () {

	}
	public override void FixedUpdate() {
		applyForce(getVelocity());
	}
	public override void Update() {
		
	}

	void OnCollisionTrigger(Collision collision) {
		
	}
}
