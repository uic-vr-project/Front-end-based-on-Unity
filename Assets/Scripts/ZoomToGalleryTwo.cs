using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomToGalleryTwo : MonoBehaviour {

    public GameObject camera;
    public Animator camAnimater;
    public GameObject gallery2cam;
    public GameObject assetLoader;

    void TransCam()
    {
        camera.SetActive(false);
        gallery2cam.SetActive(true);
        assetLoader.SetActive(true);
    }


    void OnMouseDown()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is clicked the GameObject.");
        camAnimater.SetTrigger("Gallery2");
        camAnimater.speed = 1.0f;
        Invoke("TransCam", 2f);
    }

    public void Click()
    {
        
        camera.SetActive(true);
        gallery2cam.SetActive(false);
        camera.transform.Translate(new Vector3(0, 61.6f, 0));
        camera.transform.Rotate(new Vector3(180, 0, 0));
    }

    // Use this for initialization
    void Start()
    {
        camAnimater.speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
