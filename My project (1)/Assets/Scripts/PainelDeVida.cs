using UnityEngine;
using UnityEngine.UI;

public class PainelDeVida : MonoBehaviour
{
    public Personagem personagem;
    
    public Slider SliderVidas;
    public Slider SliderEnergia;
    
    
    void Start()
    {
        SliderVidas.minValue = 0;
        SliderVidas.maxValue = personagem.getVidas();
        
        SliderVidas.minValue = 0;
        SliderVidas.maxValue = personagem.getEnergia();
    }

    
    void Update()
    {
        SliderVidas.value = personagem.getEnergia();
        SliderVidas.value = personagem.getVidas();
    }
}
