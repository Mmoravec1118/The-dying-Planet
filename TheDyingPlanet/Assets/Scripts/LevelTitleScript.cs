using UnityEngine;
using System.Collections;

public class LevelTitleScript : MonoBehaviour {

    public int DisplayTimer;
    private int displayTimer;
    private bool isTimerRunning;
    
    // Use this for initialization
	void Start () 
    {
        displayTimer = DisplayTimer;
        isTimerRunning = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (isTimerRunning == true)
        {
            if (displayTimer <= 0)
            {
                gameObject.GetComponent<RectTransform>().Rotate(new Vector3(0, 1, 0), 90f);
                isTimerRunning = false;
            }
            else
            {
                displayTimer--;
            }
        }
	}
}
