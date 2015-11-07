using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public List<GameObject> Balls;
    public float Timer = 1;

	void Start () {
	
	}
	
	void Update () {


        Timer -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            Timer = 0;
        }

        if (Timer<=0)
        {
            int randomBallIndex = Random.Range(0,11);
            Instantiate(Balls[randomBallIndex], new Vector3(Random.Range(-10,10),35,0), Quaternion.identity);
            Timer = 1;
        }


	}
}
