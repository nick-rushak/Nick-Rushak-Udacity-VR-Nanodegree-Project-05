using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInformation : MonoBehaviour {

    public GameObject exhibitInfo;

    public void DisplayInfo()
    {
        exhibitInfo.SetActive(true);
    }

    public void CloseExhibitInfo()
    {
        exhibitInfo.SetActive(false);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
