using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGraphNode
{
    int Id { get; set; }
    Vector3 VectorPosition { get; }
    int XPosition { get; set; }
    int YPosition { get; set; }
}
