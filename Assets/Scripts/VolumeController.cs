using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the Slider in the scene

    private void Start()
    {
        // Set the slider's initial value to match the current volume
        if (BackgroundMusicManager.Instance != null && volumeSlider != null)
        {
            volumeSlider.value = BackgroundMusicManager.Instance.GetVolume();
            volumeSlider.onValueChanged.AddListener(BackgroundMusicManager.Instance.SetVolume);
        }
    }
}
