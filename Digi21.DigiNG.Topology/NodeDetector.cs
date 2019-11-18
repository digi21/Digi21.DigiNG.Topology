using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Digi21.DigiNG.Topology
{
    public static class NodeDetector
    {
        public static IEnumerable<IGrouping<Point2D, VertexPointer>> DetectNodes(this IEnumerable<ReadOnlyLine> lines) { throw null; }
        public static IEnumerable<IGrouping<Point2D, VertexPointer>> DetectNodes(this IEnumerable<ReadOnlyLine> model, Func<ReadOnlyLine, bool> analyzeThisLine) { throw null; }
        public static IEnumerable<IGrouping<Point2D, VertexPointer>> DetectNodes(this IEnumerable<ReadOnlyLine> model, Func<Point2D, bool> insertNodeAtThisCoordinates) { throw null; }
        public static IEnumerable<IGrouping<Point2D, VertexPointer>> DetectNodes(this IEnumerable<ReadOnlyLine> model, Func<ReadOnlyLine, bool> analyzeThisLine, Func<Point2D, bool> insertNodeAtThisCoordinates) { throw null; }
        public static IEnumerable<Point2D> FindAll(this IEnumerable<IGrouping<Point2D, VertexPointer>> nodes, Point2D point, double distance) { throw null; }
        public static IEnumerable<Point2D> FindAll(this IEnumerable<IGrouping<Point2D, VertexPointer>> nodes, Point2D point, double distance, Func<IGrouping<Point2D, VertexPointer>, bool> includeCoordinateOfThisNode) { throw null; }
    }
}
