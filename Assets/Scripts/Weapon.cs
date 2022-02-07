using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Weapon : MonoBehaviour 
{
    private ParticleSystem PS;

	void Awake () 
    {
        PS = GetComponent<ParticleSystem>();
	}
	
	void Update () 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            PS.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            PS.Stop();
        }
	}
}
