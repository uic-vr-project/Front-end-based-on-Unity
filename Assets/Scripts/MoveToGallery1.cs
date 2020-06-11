using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MoveToGallery1 : MonoBehaviour {

    public GameObject button;
    public Animator camAnimater;

    

	// Use this for initialization
	void Start () {

        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            button.SetActive(false);
            //gallery1Animation.Play();
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
