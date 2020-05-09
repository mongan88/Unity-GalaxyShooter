using Assets.Configuration;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] // Allows value to be modified in the designer
    private float _speed = 1;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    public void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    public void Update()
    {
        var horizontalInput = Input.GetAxis(Constants.HorizontalInputKey);
        var verticalInput = Input.GetAxis(Constants.VerticalInputKey);

        var direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
