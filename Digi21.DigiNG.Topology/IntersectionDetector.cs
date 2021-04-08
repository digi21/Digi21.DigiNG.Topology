using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Digi21.DigiNG.Topology
{
    public static class IntersectionDetector
    {
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this ReadOnlyLine line, IEnumerable<ReadOnlyLine> entities) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsOfThisLine) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, ReadOnlyLine, bool> analyzeIntersectionsBetweenThisLines) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this ReadOnlyLine line, IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsWithThisLine) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this ReadOnlyLine line, IEnumerable<ReadOnlyLine> entities, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsOfThisLine, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsOfThisLine, Func<ReadOnlyLine, ReadOnlyLine, bool> analyzeIntersectionsBetweenThisLines) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, ReadOnlyLine, bool> analyzeIntersectionsBetweenThisLines, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this ReadOnlyLine line, IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsWithThisLine, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
        public static IEnumerable<IGrouping<Point2D, SegmentPointer>> DetectIntersections(this IEnumerable<ReadOnlyLine> entities, Func<ReadOnlyLine, bool> analyzeIntersectionsOfThisLine, Func<ReadOnlyLine, ReadOnlyLine, bool> analyzeIntersectionsBetweenThisLines, Func<Point2D, bool> insertIntersectionInThisCoordinate) => throw null;
    }
}
