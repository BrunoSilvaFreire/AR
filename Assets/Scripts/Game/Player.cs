using System;
using UnityEngine;
namespace Game {
    public class Player : MonoBehaviour {

        public static Player Instance {
            get;
            private set;
        }

        private void Awake() {
            Instance = this;
        }
        public int score;
    }
}