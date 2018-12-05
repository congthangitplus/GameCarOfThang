using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour {

    public Text score;
    int scores = 0;
    public static int hightScore;
    public Text HightScore;

    // Use this for initialization
    void Start () {
        StarGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StarGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Data data = (Data)bf.Deserialize(file);
            file.Close();
            // 4
            hightScore = Data.score;
            HightScore.text = hightScore.ToString();
            //min = save.min;
            //minText.text = min.ToString();
            //nb1 = save.nb1;
            //nb1Text.text = nb1.ToString();
            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "barriercar")
        {

            Destroy(col.gameObject);
            Upscore();
        }

        if (col.gameObject.tag == "itemNgang" || col.gameObject.tag == "itemDoc")
        {
            Destroy(col.gameObject);
        }
    }

    void Upscore()
    {

        scores++;
        score.text = "Score: " + scores.ToString();

    }
    
}
