using System.Globalization;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5.0f;

    public string movementAxisName = "Vertical";

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isPlayer)
        {
            spriteRenderer.color = SaveController.Instance.colorPaddle_Player1;
        }
        else
        {
            spriteRenderer.color = SaveController.Instance.colorPaddle_Player2;
        }

    }

    // Update is called once per frame
    void Update()
    {
        float moveinput = Input.GetAxis(movementAxisName);
        Vector3 newPosition = transform.position + Vector3.up * moveinput * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, -4.8f, 3.5f);
        transform.position = newPosition;

    }        


}
