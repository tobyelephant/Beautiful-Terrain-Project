using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneDynamism
{
    public class BallSpawner : MonoBehaviour
    {        
        private int totalBallsSpawned = 0;
        public int maxBallsCount = 50;
        public GameObject ballToSpawn;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(!ballToSpawn || totalBallsSpawned > maxBallsCount){
                return;
            }
            float x = Random.Range(180f, 200.0f);
            float y = 10.0f;
            float z = Random.Range(44.0f, 90.0f);

            GameObject spawned = Instantiate<GameObject>(ballToSpawn);
            spawned.GetComponent<Transform>().position = new Vector3(x, y, z);
            totalBallsSpawned ++;
        }
    }
}