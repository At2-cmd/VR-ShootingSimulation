using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour, IInitializable
{
    public void Initialize()
    {
        Debug.Log("Game Manager Initialized");
    }
}
