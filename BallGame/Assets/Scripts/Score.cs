using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform playerBall;
    public Text scoreText;

	// Update is called once per frame
	void Update () {
        scoreText.text = playerBall.position.z.ToString("0");
		
	}
}
