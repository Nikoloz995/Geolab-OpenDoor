using UnityEngine;
using System.Collections;

public class ItemBox : MonoBehaviour {
    public float boxSpeed = 0.5f;
    public float deadLine = 8.5f;
	void Start () {
	
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < deadLine)
                transform.Translate(new Vector3(1, 0, 0) * boxSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -deadLine)
             transform.Translate(new Vector3(-1, 0, 0) * boxSpeed);

        }
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        GlobalParams.score++;
    }






}
