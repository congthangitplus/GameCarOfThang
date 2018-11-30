using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarsControll : MonoBehaviour {

    public float carSpeed, jumpPow = 220f;
    public float maxPoa = 18.4f ;
    Vector2 position;
    public Uimaneger ui;
    public MusicManeger am;
    public Text score;
    public bool lines;
    int scores = 0;
    public Rigidbody2D r2;
    //public Carspaner ac;

    //void Upscore()
    //{

    //    scores++;
    //    score.text = "Score: " + scores.ToString();

    //}
    //void dk()
    //{
    //    if (position.y >= Carspaner.cad)
    //    {
    //        Upscore();
    //    }
    //}

    public void Awake()
    {
        am.carSound.Play();
    }
	// Use this for initialization
	void Start ()
    {
        
        //ui = GetComponent<Uimaneger> ();
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        // xe di chuyển qua trái phải
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -18.4f, 18.4f);
        position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        position.y = Mathf.Clamp(position.y, -3.7f, 52.8f);
        transform.position = position;
        //end
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (lines)
        //    {

        //        r2.AddForce(Vector2.up * jumpPow);
        //    }
        //}
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "barriercar")
        {

            Destroy(gameObject);
            ui.gameOverActivated();
            ui.menubutton();
            am.carSound.Stop();
        }
        
    }
}
