using UnityEngine;

public class CameraControlExam06 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float offset;
    public Camera targetCamera;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 player1Pos = player1.transform.position;
        Vector3 player2Pos = player2.transform.position;

        // Student code ...
        Vector3 center = (player1Pos + player2Pos) / 2f;
        transform.position = new Vector3(center.x, transform.position.y, center.z - offset);
        float distance = Vector3.Distance(player1Pos, player2Pos);
        targetCamera.orthographicSize = distance;
    }
}
