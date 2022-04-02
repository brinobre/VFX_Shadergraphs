using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingObject : MonoBehaviour
{
    new Renderer renderer;
    new Camera camera;


    private void Start()
    {
        renderer = GetComponent<Renderer>();
        camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = camera.WorldToScreenPoint(transform.position);
        screenPoint.x = screenPoint.x / Screen.width;
        screenPoint.y = screenPoint.y / Screen.height;
        renderer.material.SetVector("ObjScreenPos_", screenPoint);
    }
}
