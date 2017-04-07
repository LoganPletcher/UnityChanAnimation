using UnityEngine;
using System.Collections;

public class CharacterAnimatorControllerScript : MonoBehaviour {

    public AudioSource footsource;
    public AudioClip footstep;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void FootDown()
    {
        footsource.clip = footstep;
        footsource.Play();
    }
}
