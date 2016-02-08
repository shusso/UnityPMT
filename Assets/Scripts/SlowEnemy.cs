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
	new public void OnCollisionEnter(Collision collision) {
		
	}
}