using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _spawnUp = 0.5f;
    [SerializeField] private float _spawnLeft = 0.2f;
    [SerializeField] private GameObject _seedPrefab;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _mouseSensitivity;
    [SerializeField] private float _throwForce = 5.0f;

    public bool _isHoldingSeed;

    private Transform _cameraTrans;
    private float _rotationX;
    private float _rotationY;
    private Rigidbody _seedRB;
    private Collider _seedCollider;

    // ------------------------------------------------------------------------
    private void Start ()
    {
        _cameraTrans = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        LookAndMove();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isHoldingSeed)
            {
                ThrowSeed();
            }
            else
            {
                SpawnSeed();
            }
        }
    }

    // ------------------------------------------------------------------------
    private void SpawnSeed ()
    {
        _isHoldingSeed = true;

        // STEP 4 -------------------------------------------------------------
        // Fix this line so that the Player GameObject is the PARENT of the seed.
        // That way, the seed will move with the player.

        GameObject seed = Instantiate(_seedPrefab);

        // STEP 4 -------------------------------------------------------------

        _seedRB = seed.GetComponent<Rigidbody>();
        _seedRB.isKinematic = true;
        _seedCollider = seed.GetComponent<Collider>();
        _seedCollider.enabled = false;

        // STEP 5 -------------------------------------------------------------
        // Set the position of the seed to be DIRECLTY TO THE LEFT of the PLAYER.
        // You might want to use _spawnUp and _spawnLeft to put the seed to the
        //      left and slightly above the player.
        // You will probably also need Transform.TransformDirection() ;)

        
        // STEP 5 -------------------------------------------------------------
    }
    
    // ------------------------------------------------------------------------
    private void ThrowSeed ()
    {
        _isHoldingSeed = false;
        _seedRB.isKinematic = false;
        _seedCollider.enabled = true;

        Vector3 throwDirection =
            transform.TransformDirection(Vector3.up + Vector3.forward) *
            _throwForce;
        _seedRB.AddForce(throwDirection * _throwForce, ForceMode.Impulse);

        _seedRB.gameObject.transform.parent = null;

        _seedRB = null;
        _seedCollider = null;

        // STEP 7 -------------------------------------------------------------
        // Set the animation parameters to play the throwing animation.
        


        // STEP 7 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void LookAndMove()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        _rotationY += mouseY * _mouseSensitivity;
        _rotationY = Mathf.Clamp(_rotationY, -60.0f, 60.0f);

        float mouseX = Input.GetAxis("Mouse X");
        _rotationX += mouseX * _mouseSensitivity;

        _cameraTrans.localEulerAngles = new Vector3(-_rotationY, 0, 0);
        transform.localEulerAngles = new Vector3(0, _rotationX, 0);

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(
            ((vertical * Vector3.forward) + (horizontal * Vector3.right))
            * _moveSpeed * Time.deltaTime
        );

        // STEP 8 -------------------------------------------------------------
        // Set the animation parameters to play the walking animation.
        // You might need the mouseY, mouseX, vertical, and horizontal variables
        //      that are above this step :)


        // STEP 8 -------------------------------------------------------------
    }
}
