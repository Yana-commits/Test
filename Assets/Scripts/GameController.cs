using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    private int fieldSize = 40;

    public List<Vector2Int> positions;

    private BaseField field;

    private Base _base;

    private Player player;
    public Player Player
    {
        get
        {
            return player;
        }

        set
        {
            player = value;
        }
    }

    private Enemy enemy;
    public Enemy Enemy
    {
        get
        {
            return enemy;
        }

        set
        {
            enemy = value;
        }
    }

    private EnemyBase enemyBase;

    [Inject]
    private GameObject navMesh;


    [Inject]
    private void Construct(BaseField field, Base _base, EnemyBase enemyBase)
    {
        this.field = field;
        this._base = _base;
        this.enemyBase = enemyBase;
    }

    private void Awake()
    {
        FillPositions();
    }
    void Start()
    {
        InitializeLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FillPositions()
    {
        positions = new List<Vector2Int> {
            new Vector2Int(0, fieldSize / 2),
            new Vector2Int(0,-fieldSize / 2),
            new Vector2Int(0,-fieldSize / 2 - 1),
            new Vector2Int(0, -fieldSize / 2+1),
             new Vector2Int(0,fieldSize / 2+1),
             new Vector2Int(0,fieldSize / 2 - 1)
        };
    }

    public void InitializeLevel()
    {
        _base.transform.SetParent(field.transform);
        enemyBase.transform.SetParent(field.transform);
        field.transform.SetParent(navMesh.transform);

    }

    private void WallInstaller()
    {
        //var emptySquares = (fieldSize * fieldSize) * 0.05f;

        //float offset = ((float)fieldSize) / 2f;

        //Vector3 startPosition = new Vector3(transform.position.x - offset, transform.position.y - offset, transform.position.z - 2);

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

        //                GameObject newWall = Instantiate(wallPrefab,
        //               new Vector3(startPosition.x + i, startPosition.y + j, startPosition.z), Quaternion.identity) as GameObject;
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
