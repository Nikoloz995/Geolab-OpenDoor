using UnityEngine;
using System.Collections;

public class boxMotion : MonoBehaviour {

    public float BoxSpeed = 5;
    float limitedArea = 6.5f;
	
    void Start () {


	
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(other);
    
    }
	
	void Update () {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x >= limitedArea)
                return;
            gameObject.transform.Translate(new Vector3(1 * BoxSpeed, 0, 0) * Time.deltaTime);
        
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x <= -limitedArea)
                return;
            gameObject.transform.Translate(new Vector3(-1 * BoxSpeed, 0, 0) * Time.deltaTime);
        
        }
	
	}
}
