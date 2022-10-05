using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject puntaje;
    public int puntos = 0;

    public AudioSource audioSource { get { return GetComponent<AudioSource>(); } }
    public AudioClip clip;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //metodo que usara leer el score
    
    public void OnEnter()
    {
        Destroy(this);
        audioSource.PlayOneShot(clip);
        puntos += 1;
        puntaje.GetComponent<Text>().text = puntos.ToString();
    }
}
