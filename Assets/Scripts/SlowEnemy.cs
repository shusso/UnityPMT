using UnityEngine;
using System.Collections;
using BaseEnemy;

public class SlowEnemy : EnemyBase {
	public override void Start() {
	}
	public override void Update() {
	}
	public override void FixedUpdate() {
		applyForce(getVelocity());
	}

	/*TODO is there  a way to call the BaseClass
		   collider if we derive new collider
		   in the Child?
	new public void OnCollisionEnter(Collision collision) {		
	}
	*/
}