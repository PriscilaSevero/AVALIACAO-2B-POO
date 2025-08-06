using UnityEngine;
using UnityEngine.SceneManagement;
public class carregarCena : MonoBehaviour
{
    public string nomeDaCena;

    public void carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
