using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphFactory
{
    public static T[,] CreateGraphWithId<T>(int sizeX, int sizeY)
    where T : IGraphNode, new()
    {
        var graph = new T[sizeX, sizeY];

        var count = 0;

        for (int xAxis = 0; xAxis < graph.GetLength(0); xAxis++)
            for (int yAxis = 0; yAxis < graph.GetLength(1); yAxis++)
            {
                graph[xAxis, yAxis] = new T { Id = count, XPosition = xAxis, YPosition = yAxis };
                count++;
            }

        return graph;
    }
}
