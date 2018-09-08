using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance = null;

    public Button pouseButton;
    public Button backButton;
    public Button resmueButton;
    public Button resetButton;

    void Start () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        backButton.gameObject.SetActive(false);
        resmueButton.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(false);
    }
	
	void Update () {
		
	}

    public void stop() {
        pouseButton.gameObject.SetActive(false);

        backButton.gameObject.SetActive(true);
        resmueButton.gameObject.SetActive(true);

        FindObjectOfType<PlayerController>().enabled = false;
        FindObjectOfType<PlayerController>().GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public void die() {
        resetButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);

        pouseButton.gameObject.SetActive(false);

        FindObjectOfType<PlayerController>().enabled = false;
        FindObjectOfType<PlayerController>().GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public void resmue() {
        pouseButton.gameObject.SetActive(true);

        backButton.gameObject.SetActive(false);
        resmueButton.gameObject.SetActive(false);

        FindObjectOfType<PlayerController>().enabled = true;
        FindObjectOfType<PlayerController>().GetComponent<Rigidbody2D>().velocity = new Vector2(FindObjectOfType<PlayerController>().GetComponent<Rigidbody2D>().velocity.x, FindObjectOfType<PlayerController>().GetComponent<Rigidbody2D>().velocity.y);
    }
    
}
