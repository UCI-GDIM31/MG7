using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _popUpTime = 1.0f;
    [SerializeField] private float _popUpSpeed = 5.0f;
    [SerializeField] private Player _player;

    private bool _doPopUpAnimation;
    private float _popUpTimeRemaining;

    // STEP 2 -----------------------------------------------------------------
    // OnEnable is another Unity method like Start() and Update() that's called
    //      whenever a Component is enabled.
    // This happens if if the Component is set to enabled, OR when the GameObject
    //     the Component is attached to is set to active (has SetActive called). 
    //
    // We are going to use the _popUpTime, _popUpSpeed, _doPopUpAnimation, and
    //      _popUpTimeRemaining variables to create a timer that makes the Bird
    //      move upwards when it becomes active.
    //
    // The bird will move for _popUpTime seconds after becoming enabled.
    // In OnEnable, set up this timer. 
    // If you need help, this code will be VERY SIMLIAR to previous timers you've
    //      coded! :)
    private void OnEnable()
    {
        
    }
    // STEP 2 -----------------------------------------------------------------

    private void Update()
    {
        // STEP 3 -------------------------------------------------------------
        // Update your timer, and if the bird should still be animating,
        //      move it upwards with Translate.


        // STEP 3 -------------------------------------------------------------



        // STEP 6 -------------------------------------------------------------
        // Check if the player is currently holding a seed by checking the value
        //      of Player._isHoldingSeed.
        // If the player is holding a seed, make the bird look at the player
        //      with the Transform.LookAt() method:
        //      https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Transform.LookAt.html
        


        // STEP 6 -------------------------------------------------------------
    }
}
