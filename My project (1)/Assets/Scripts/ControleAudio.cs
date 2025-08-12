using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public int VolumeFalas;
    public int VolumeToque;
    public bool musica;
    
    
    public Slider VolumeSlider;
    public Slider VolumeSFXSlider;
    public Slider VolumeFalaSlider;
    public Slider VolumeToqueSlider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;
    
    void Start()
    {
        musica = toggleMusica.isOn;
        Volume = (int)VolumeSlider.value;
        VolumeSFX = (int)VolumeSFXSlider.value;
        VolumeFalas = (int)VolumeFalaSlider.value;
        VolumeToque = (int)VolumeToqueSlider.value;
    }

    
    void Update()
    {
        musica = toggleMusica.isOn;
        Volume = (int)VolumeSlider.value;
        VolumeSFX = (int)VolumeSFXSlider.value;
        VolumeFalas = (int)VolumeFalaSlider.value;
        VolumeToque = (int)VolumeToqueSlider.value;

        if (musica ==  true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;
        }
        else
        {
            textoMusica.text = "Desligado";
            textoMusica.color = Color.red; 
        }
    }
}
