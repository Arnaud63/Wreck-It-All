using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    private Animator characterAnimator;
    private int isWalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        characterAnimator = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = characterAnimator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("z");

        /*
        if(!isWalking && forwardPressed)
        {
            characterAnimator.SetBool(isWalkingHash, true);
        }

        if(isWalking && !forwardPressed)
        {
            characterAnimator.SetBool(isWalkingHash, false);
        }
        */
    }
}
