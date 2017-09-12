using UnityEngine;
using System.Collections;

public class TriggerLevelLoad : MonoBehaviour {

	public string nameOfLevelToLoad  = "";
    public int advanceLevel = 10;
    public int count;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Pickup")
		{
            count++;
            if(count == advanceLevel)
            {
                Application.LoadLevel(nameOfLevelToLoad);
            }
		}
	}
}
