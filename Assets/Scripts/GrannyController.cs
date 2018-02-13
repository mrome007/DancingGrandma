using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyController : MonoBehaviour 
{
    public GameObject GrannyObject;
    private Animator grannyAnimator;

    private void Start()
    {
        grannyAnimator = GrannyObject.GetComponent<Animator>();
    }

    private void Update()
    {

    }

    public void ChangeAnimation(string trigger)
    {
        grannyAnimator.SetTrigger(trigger);
    }
}
