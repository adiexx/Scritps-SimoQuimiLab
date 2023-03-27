using UnityEngine;

public class Controller : MonoBehaviour {

    public Transform characterHead;

    float rotationX = 0.1f;
    float rotationY = 0.1f;

    float angleYmin = -90;
    float angleYmax = 90;

    float smoothRotx = 0;
    float smoothRoty = 0;

    float smoothCoefx = 0.5f;
    float smoothCoefy = 0.5f;

    void Start() {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void LateUpdate() {
        transform.position = characterHead.position;
    }

    void Update() {

        float verticalDelta = Input.GetAxisRaw("Mouse Y") ;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") ;

        smoothRotx = Mathf.Lerp(smoothRotx, horizontalDelta, smoothCoefx);
        smoothRoty = Mathf.Lerp(smoothRoty, verticalDelta, smoothCoefy);

        rotationX += smoothRotx;
        rotationY += smoothRoty;

        rotationY = Mathf.Clamp(rotationY, angleYmin, angleYmax);


        transform.localEulerAngles = new Vector3(-rotationY, 0);

    }

}