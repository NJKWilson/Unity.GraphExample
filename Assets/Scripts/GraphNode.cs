using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : IGraphNode
{
    public int Id { get; set; }
    
    public Vector3 VectorPosition { get => new Vector3(XPosition, 0, YPosition); }
    public int XPosition { get; set; }
    public int YPosition { get; set; }
}
