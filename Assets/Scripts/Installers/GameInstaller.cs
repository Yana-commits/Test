using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{

    [SerializeField]
    private GameObject navMesh;

    public override void InstallBindings()
    {
        Container.Bind<GameController>().FromComponentInHierarchy().AsSingle().NonLazy();

        Container.BindInstance(navMesh);
    }
}