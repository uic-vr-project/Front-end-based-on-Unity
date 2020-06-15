using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomToGalleryOne : MonoBehaviour {

    public GameObject camera;
    public Animator camAnimater;
    public GameObject gallery1cam;
    public GameObject assetLoader;

    void TransCam() {
        camera.SetActive(false);
        gallery1cam.SetActive(true);
        assetLoader.SetActive(true);
    }


    void OnMouseDown()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is clicked the GameObject.");
        camAnimater.SetTrigger("Gallery1");
        camAnimater.speed = 1.0f;
        Invoke("TransCam", 2f);
        
    }

    public void Click()
    {  
        camera.SetActive(true);
        gallery1cam.SetActive(false);
        camera.transform.Translate(new Vector3(0, 61.6f, 0));
        camera.transform.Rotate(new Vector3(180, 0, 0));
    }

    // Use this for initialization
    void Start () {
        camAnimater.speed = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}