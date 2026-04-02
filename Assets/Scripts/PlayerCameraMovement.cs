using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCameraMovement : MonoBehaviour
{
    [SerializeField] private float cameraMoveSpeed;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if(Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            // rotate camera left
            transform.Rotate(0, -cameraMoveSpeed * Time.deltaTime, 0);
        }
        else if(Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
			// rotate camera right
			transform.Rotate(0, cameraMoveSpeed * Time.deltaTime, 0);
		}
    }
}
