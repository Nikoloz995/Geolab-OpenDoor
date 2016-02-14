using UnityEngine;
using System.Collections;

public class ItemBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        if (transform.position.y < -7.5f)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
    }

  

   
}
