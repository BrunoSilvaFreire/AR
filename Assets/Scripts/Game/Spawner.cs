using System;
using UnityEngine;
using Random = UnityEngine.Random;
namespace Game {
    public class Spawner : MonoBehaviour {
        public float minRadius = 5;
        public float maxRadius = 15;
        public Target prefab;
        private float _timeUntilSpawn;
        public float cooldown = 5;
        public Vector3 SelectSpawnLocation() {
            return new Vector3(
                Random.Range(-1.0F, 1.0F),
                Random.Range(-1.0F, 1.0F),
                Random.Range(-1.0F, 1.0F)
            ).normalized * Random.Range(minRadius, maxRadius);
        }
        public void Spawn() {
            var p = Instantiate(prefab);
            p.transform.position = SelectSpawnLocation();
        }
        private void Start() {
            _timeUntilSpawn = cooldown;
        }
        private void Update() {
            _timeUntilSpawn -= Time.deltaTime;
            if (_timeUntilSpawn < 0) {
                Spawn();
                _timeUntilSpawn = cooldown - _timeUntilSpawn;
            }
        }
    }
}