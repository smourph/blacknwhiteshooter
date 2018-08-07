using UnityEngine;
using System.Collections;

namespace BlackNWhiteShooter
{
    public abstract class Mover : MonoBehaviour
    {
        public float speed = 1.5f;

        protected Collider2D _collider;
        protected Rigidbody2D _rb2d;
        protected Transform _transform;

        protected virtual void Awake()
        {
            _collider = GetComponent<Collider2D>();
            _rb2d = GetComponent<Rigidbody2D>();
            _transform = GetComponent<Transform>();
        }

        protected void Move(Vector2 moveDirection, Vector2 turnTarget)
        {
            // The movement is a composition of a rotation and a translation
            TurnToTarget(turnTarget);
            MoveTo(moveDirection);
        }

        private void MoveTo(Vector2 direction)
        {
            _rb2d.velocity = direction * speed;
        }

        private void TurnToTarget(Vector2 target)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, target - _rb2d.position);
        }
    }
}
