using UnityEngine;

namespace BlackNWhiteShooter.Player
{
    public class PlayerMovement : BlackNWhiteShooter.Mover
    {
        void FixedUpdate()
        {
            // Inputs
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float horizontalAxis = Input.GetAxisRaw("Horizontal");
            float verticalAxis = Input.GetAxisRaw("Vertical");

            // The direction move is relative to the orientation of the player
            Vector2 direction = _transform.up * verticalAxis + _transform.right * horizontalAxis;

            // Give direction and orientation to calculate the next move
            Move(direction, mousePosition);
        }
    }
}
