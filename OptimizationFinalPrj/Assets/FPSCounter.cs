using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    private int frameCount;
    private float deltaTime = 0.0f;

    void Update()
    {
        frameCount++;
        deltaTime += Time.unscaledDeltaTime;
        if (deltaTime > 1.0f)
        {
            float fps = frameCount / deltaTime;
            frameCount = 0;
            deltaTime -= 1.0f;
            fpsText.text = string.Format("FPS: {0}", fps);
        }
    }
}