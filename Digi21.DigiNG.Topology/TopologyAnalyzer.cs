using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.Topology
{
    public static class TopologyAnalyzer
    {
        public static void AnalyzeCentroids(this IEnumerable<ClosedLoopWithHoles> polygons, IEnumerable<ReadOnlyText> centroids) => throw null;
        public static void AnalyzeCentroids(this IEnumerable<ClosedLoopWithHoles> polygons, IEnumerable<ReadOnlyText> centroids, Action<int> progressChanged) => throw null;
        public static void AnalyzeCentroids(this IEnumerable<ClosedLoopWithHoles> polygons, IEnumerable<ReadOnlyText> centroids, Action<ClosedLoopWithHoles, IEnumerable<ReadOnlyText>> duplicatedCentroids) => throw null;
        public static void AnalyzeCentroids(this IEnumerable<ClosedLoopWithHoles> polygons, IEnumerable<ReadOnlyText> centroids, Action<ClosedLoopWithHoles, IEnumerable<ReadOnlyText>> duplicatedCentroids, Action<int> progressChanged) => throw null;
        public static IEnumerable<ClosedLoopWithHoles> AnalyzeTopology(this IEnumerable<Entity> entities, bool analyzePolygonRelationship) => throw null;
        public static IEnumerable<ClosedLoopWithHoles> AnalyzeTopology(this IEnumerable<Entity> entities, bool analyzePolygonRelationship, Action<int> progressChanged) => throw null;
        public static IEnumerable<ClosedLoopWithHoles> AnalyzeTopology(this IEnumerable<Entity> entities, bool analyzePolygonRelationship, Action<int> progressChanged, Action<ReadOnlyLine> lineWithDoublePoints, Action<Entity> entityWithOnlyOnePoint, Action<IEnumerable<ReadOnlyLine>> openPolygon) => throw null;
    }
}
