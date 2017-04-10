using UnityEngine;
using System.Collections;

public class CharacterAnimatorControllerScript : MonoBehaviour {

    public AudioSource footsource;
    public AudioClip footstep;

    private Animator _animator;

    public bool w;
    public bool r;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        w = Input.GetKey("w");
        r = Input.GetKey("z");

        _animator.SetBool("Walk", w);
        _animator.SetBool("Run", r);
	}

    //public void FootDown()
    //{
    //    footsource.clip = footstep;
    //    footsource.Play();
    //}
}
