using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnPKeyPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool LeftButtonPressed{ get; private set;}
public bool LeftButtonHeld{ get; private set;}
public bool RightButtonPressed{ get; private set;}

private void Update()
{
        LeftButtonPressed=Input.GetMouseButtonDown(0);
        LeftButtonHeld=Input.GetMouseButton(0);
        RightButtonPressed = Input.GetMouseButtonDown(1);
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnPKeyPressed.Invoke();
        }
}


}
