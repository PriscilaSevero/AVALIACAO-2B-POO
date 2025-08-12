using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class ControleAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;
    
    public Slider VolumeSlider;
    public Slider VolumeSFXSlider;
    public Toggle toggleMusica;
    void Start()
    {
        musica = toggleMusica.is
    }

    
    void Update()
    {
        
    }
}
