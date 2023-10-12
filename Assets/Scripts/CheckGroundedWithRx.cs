using UniRx;
using UnityEngine;

public class CheckGroundedWithRx : MonoBehaviour
{
    private bool _isGrounded;

    public bool IsGrounded { get => _isGrounded; }
    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _characterController
            .ObserveEveryValueChanged(x => x.isGrounded)
            .ThrottleFrame(5)
            .Subscribe(x => _isGrounded = x);
    }
}