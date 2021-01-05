using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphController {
    
    public IGraphNode[,] _graph;
    
    public GraphController()
    {
        _graph = GraphFactory.CreateGraphWithId<GraphNode>(10,10);
    }
}
