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

            /** To prevents weird moves when the vessel approach to the position
             * of the mouse, we set a minimum distance to allow the movement **/
            Vector2 direction;
            if (Vector2.Distance(_transform.position, mousePosition) > 0.1f)
            {
                // The vessel moves relatively to the orientation of the player
                direction = _transform.up * verticalAxis + _transform.right * horizontalAxis;
            }
            else
            {
                // The vessel doesn't move
                direction = new Vector2(0.0f, 0.0f);
            }

            // Give direction and orientation to calculate the next move
            Move(direction, mousePosition);
        }
    }
}
