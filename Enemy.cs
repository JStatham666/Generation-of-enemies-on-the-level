using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector3 _direction;

    public void Init(Vector3 direction) =>
        _direction = direction;

    private void Update() =>
        Move();

    private void Move() =>
        transform.Translate(_direction * _speed * Time.deltaTime);
}