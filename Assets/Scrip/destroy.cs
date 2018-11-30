using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour {

    public Text score;
    int scores = 0;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "barriercar") {

			Destroy (col.gameObject);
            Upscore();
        }
	}


    void Upscore()
    {

        scores++;
        score.text = "Score: " + scores.ToString();

    }
}
