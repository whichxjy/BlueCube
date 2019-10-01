using UnityEngine;
public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    private void Start() {
        offset = new Vector3(0, 1, -5);
    }

    private void Update() {
        transform.position = player.position + offset;
    }

}
