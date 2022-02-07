using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    private Camera _camera;
    private ParticleSystem PS;

    void Awake()
    {
        PS = GetComponent<ParticleSystem>();
    }
    void Start()
    {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnGUI()
    {
        int size = 20;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "X");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PS.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            PS.Stop();
        }
    }    
}