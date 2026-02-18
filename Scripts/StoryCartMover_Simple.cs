using UnityEngine;

public class StoryCartMover_Simple : MonoBehaviour
{
    public float startZ = -20f;
    public float endZ = -12f;
    public float durationSeconds = 8f;

    Vector3 startPos;
    Vector3 endPos;
    float t;

    void Start()
    {
        startPos = new Vector3(transform.position.x, transform.position.y, startZ);
        endPos   = new Vector3(transform.position.x, transform.position.y, endZ);

        transform.position = startPos;
        t = 0f;
    }

    void Update()
    {
        if (durationSeconds <= 0f) return;

        t += Time.deltaTime / durationSeconds;
        t = Mathf.Clamp01(t);

        transform.position = Vector3.Lerp(startPos, endPos, t);
    }
}
