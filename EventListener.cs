using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        renderer.material.color = Color.red;
    }
    public void OnEnxit()
    {
        renderer.material.color = Color.white;
    }
}
