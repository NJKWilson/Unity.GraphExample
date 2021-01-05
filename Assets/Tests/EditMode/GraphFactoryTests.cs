using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GraphFactoryTests
{
    [Test]
    public void CreateGraphWithId_Returns_InstatiatedGraph([Random(0, 100, 5)] int xAxis, [Random(0, 100, 5)] int yAxis)
    {   
        var dateTime = DateTime.Now;

        GraphFactory maths = new GraphFactory();

        var graph = GraphFactory.CreateGraphWithId<TestDataClass>(100,100);

        int expectedId = (xAxis * 100) + yAxis;

        Assert.AreEqual(expectedId, graph[xAxis, yAxis].Id);

        Assert.AreEqual(xAxis, graph[xAxis, yAxis].XPosition);

        Assert.AreEqual(yAxis, graph[xAxis, yAxis].YPosition);

        Assert.AreEqual(xAxis, graph[xAxis, yAxis].VectorPosition.x);
        Assert.AreEqual(yAxis, graph[xAxis, yAxis].VectorPosition.y);

        Debug.Log($"CreateGraph_Returns_InstatiatedGraph {DateTime.Now - dateTime}");
    }

}

public class TestDataClass : IGraphNode
{
    public int Id { get; set; }
    public Vector3 VectorPosition { get => new Vector3(XPosition, YPosition, 0); }
    public int XPosition { get; set; }
    public int YPosition { get; set; }
}