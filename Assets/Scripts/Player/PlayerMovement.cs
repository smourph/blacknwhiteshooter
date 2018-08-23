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

            // The direction move is relative to the screen
            Vector2 direction = Vector2.up * verticalAxis + Vector2.right * horizontalAxis;
            Vector2 orientation = mousePosition;

            // Give direction and orientation to calculate the next move
            Move(direction, orientation);
        }
    }
}
