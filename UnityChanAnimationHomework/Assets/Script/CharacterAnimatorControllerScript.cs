using UnityEngine;
using System.Collections;

public class CharacterAnimatorControllerScript : MonoBehaviour {

    public AudioSource footsource;
    public AudioClip footstep;

    private Animator _animator;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        bool w = Input.GetKeyDown("w");
        bool r = Input.GetKeyDown("right shift");

        _animator.SetBool("Walk", w);
        _animator.SetBool("Run", r);
	}

    public void FootDown()
    {
        footsource.clip = footstep;
        footsource.Play();
    }
}
