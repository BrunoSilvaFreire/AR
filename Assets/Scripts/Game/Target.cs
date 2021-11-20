using System;
using UnityEngine;
namespace Game {
    public class Target : MonoBehaviour {
        public void Hit() {
            Player.Instance.score++;
            Destroy(gameObject);
        }
        private void OnTriggerEnter(Collider other) {
            Hit();
        }
    }
}