using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestGraph : MonoBehaviour
{
    public TextMeshPro pfLabel;
    GraphController _graphController;
    // Start is called before the first frame update
    void Start()
    {
        _graphController = new GraphController();
        
        for (int xAxis = 0; xAxis < _graphController._graph.GetLength(0); xAxis++) {
            for (int yAxis = 0; yAxis < _graphController._graph.GetLength(1); yAxis++)
            {
                var textMeshPro = Instantiate(pfLabel);
                textMeshPro.text = $"{xAxis},{yAxis}";
                textMeshPro.rectTransform.position = _graphController._graph[xAxis, yAxis].VectorPosition;
                Instantiate(pfLabel, _graphController._graph[xAxis, yAxis].VectorPosition, Quaternion.AngleAxis(90, Vector3.right));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
