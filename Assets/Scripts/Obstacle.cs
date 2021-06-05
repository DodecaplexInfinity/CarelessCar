using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
public class Obstacle : MonoBehaviour
{
    
    // TODO Make OnMouseDown, OnMouseDrag
    [SerializeField] private Rigidbody _rigidbody;

    private Camera _camera;

    private Vector3 _offset;
    private float _zCoord;

    private bool _isControllable = true;
    
    private void Start()
    {
        _camera = Camera.main;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _zCoord = _camera.WorldToScreenPoint(_rigidbody.transform.position).z;
        var tapPosition = GetTapPosition();
        _offset = _rigidbody.transform.position - tapPosition;
    }
    
    private void OnMouseDrag()
    {
        if (!_isControllable) return;
        var newPosition = GetTapPosition() + _offset;
        _rigidbody.position = newPosition;   
    }
    
    private Vector3 GetTapPosition()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = _zCoord;
        return _camera.ScreenToWorldPoint(mousePosition);
    }
    
    public void SetControllable(bool state)
    {
        _isControllable = state;
    }
}
