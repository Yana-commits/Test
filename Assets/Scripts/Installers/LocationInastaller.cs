using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Zenject;

public class LocationInastaller : MonoInstaller
{
   
    [SerializeField]
    private int fieldSize;

    [SerializeField]
    private int walls;

    [SerializeField]
    private BaseField fieldPrefab;

    [SerializeField]
    private Base basePrefab;

    [SerializeField]
    private EnemyBase enemyBasePrefab;

    [SerializeField]
    private GameObject wallPrefab;

    public List<Vector2> squares = new List<Vector2>();

    public override void InstallBindings()
    {
        FieldInstall();
        BaseInstall();
        EnemyBaseInstall();

    }

    private void FieldInstall()
    {
        BaseField field = Container
                   .InstantiatePrefabForComponent<BaseField>(fieldPrefab, Vector2.zero, Quaternion.identity, null);

        Container.
            Bind<BaseField>().FromInstance(field).AsSingle();

        WallInstaller(field);
    }

    private void BaseInstall()
    {
        Base _base = Container
                       .InstantiatePrefabForComponent<Base>(basePrefab, new Vector2(0, -fieldSize / 2), Quaternion.identity, null);
        Container.
           Bind<Base>().FromInstance(_base).AsSingle();
    }

    private void EnemyBaseInstall()
    {
        EnemyBase enemyBase = Container
                       .InstantiatePrefabForComponent<EnemyBase>(enemyBasePrefab, new Vector2(0, fieldSize / 2), Quaternion.identity, null);
        Container.
           Bind<EnemyBase>().FromInstance(enemyBase).AsSingle();
    }

    private void WallInstaller(BaseField field)
    {

        for (int i = 0; i < fieldSize; i++)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                var square = new Vector2(i, j);
                squares.Add(square);
            }
        }

       var fillSquare = new List<Vector2>(squares);
        fillSquare.Shuffle();
        int offset = fieldSize / 2;

        for (var i = 0; i < walls; i++)
        {
            GameObject newWall = Instantiate(wallPrefab,new Vector2( fillSquare[i].x - offset, fillSquare[i].y- offset)
                       , Quaternion.identity) as GameObject;

            newWall.transform.SetParent(field.transform);
        }



        //        var emptySquares = (fieldSize * fieldSize) * 0.5f;

        //float offset = ((float)fieldSize ) / 2f;

        //Vector3 startPosition = new Vector3(transform.position.x - offset,transform.position.y -offset, transform.position.z - 2);

        //for (int i = 0; i < fieldSize; i++)
        //{
        //    for (int j = 0; j < fieldSize; j++)
        //    {

        //        if ((i * fieldSize) + j >= (fieldSize * fieldSize) - emptySquares)
        //        {

        //            emptySquares--;
        //        }

        //        else
        //        {

        //            if (emptySquares == 0 ||
        //               Random.Range(0, fieldSize * fieldSize / emptySquares) > 0)
        //            {

        //                GameObject newWall =Instantiate(wallPrefab,
        //               new Vector3(startPosition.x + i, startPosition.y + j, startPosition.z), Quaternion.identity) as GameObject;

        //                newWall.transform.SetParent(field.transform);
        //            }

        //            else
        //            {

        //                emptySquares--;
        //            }
        //        }
        //    }
        //}

    }
}
