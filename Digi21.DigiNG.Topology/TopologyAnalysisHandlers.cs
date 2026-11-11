using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.Topology
{
    /// <summary>
    /// Delegates that <see cref="TopologyAnalyzer.AnalyzeTopology"/> invokes while it builds the topology of a
    /// <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition"/>. Notification delegates may be null. EvaluateExcludeCondition is required when a topology code has a non-empty exclusion condition.
    /// </summary>
    /// <remarks>
    /// <see cref="TopologyAnalyzer.AnalyzeTopology"/> reads the properties once, when it starts. If a delegate throws an exception,
    /// <see cref="TopologyAnalyzer.AnalyzeTopology"/> stops invoking delegates, lets the native analysis finish and throws that exception
    /// after the native analysis finishes.
    /// </remarks>
    public sealed class TopologyAnalysisHandlers
    {
        public TopologyAnalysisHandlers() => throw null;

        /// <summary>
        /// Receives the progress percentage, from 0 to 100, of each phase of the analysis: forming the rings and assigning
        /// holes and centroids to them. The percentage starts again from 0 in each phase.
        /// An exception thrown by this delegate does not interrupt the analysis: <see cref="TopologyAnalyzer.AnalyzeTopology"/> stops
        /// invoking delegates and rethrows the exception when the native analysis finishes.
        /// </summary>
        public Action<int> ProgressChanged { get => throw null; set => throw null; }

        /// <summary>
        /// Receives each line with a code of the topology whose first two vertices or last two vertices have the same
        /// X and Y coordinates. If any line is reported, <see cref="TopologyAnalyzer.AnalyzeTopology"/> throws an exception after the analysis.
        /// </summary>
        public Action<ReadOnlyLine> LineWithDoublePoints { get => throw null; set => throw null; }

        /// <summary>
        /// Receives each point and each line with fewer than two vertices that has a code of the topology.
        /// If any entity is reported, <see cref="TopologyAnalyzer.AnalyzeTopology"/> throws an exception after the analysis.
        /// </summary>
        public Action<Entity> EntityWithFewerThanTwoVertices { get => throw null; set => throw null; }

        /// <summary>
        /// Receives the lines of each ring that does not enclose an area. The ring does not form a polygon.
        /// </summary>
        public Action<IEnumerable<ReadOnlyLine>> RingWithoutArea { get => throw null; set => throw null; }

        /// <summary>
        /// Receives each polygon that does not contain any centroid. Only invoked when
        /// <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.ReportPolygonsWithoutCentroid"/> is true; otherwise these polygons
        /// are discarded without being reported.
        /// </summary>
        public Action<ClosedLoopWithHoles> PolygonWithoutCentroid { get => throw null; set => throw null; }

        /// <summary>
        /// Receives the centroids of each polygon that contains more than one centroid. When no entity has a code of the
        /// topology, so that no ring can be formed, it receives every text read as a centroid.
        /// </summary>
        public Action<IEnumerable<ReadOnlyText>> DuplicatedCentroids { get => throw null; set => throw null; }

        /// <summary>
        /// Receives, once, the centroids that are not inside any polygon.
        /// </summary>
        public Action<IEnumerable<ReadOnlyText>> CentroidsWithoutPolygon { get => throw null; set => throw null; }

        /// <summary>
        /// Receives each line or polygon that has a code whose relationship is <see cref="Digi21.DigiNG.DigiTab.TopologyCodeRelationship.Required"/>
        /// or <see cref="Digi21.DigiNG.DigiTab.TopologyCodeRelationship.GuaranteesPolygon"/> and is not part of any valid polygon.
        /// Only invoked when <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.ReportPolygonsWithoutCentroid"/> is false.
        /// EntityNotInValidPolygon receives the same instance that the caller passed in the entities collection.
        /// </summary>
        public Action<Entity> EntityNotInValidPolygon { get => throw null; set => throw null; }

        /// <summary>
        /// Evaluates the <see cref="Digi21.DigiNG.DigiTab.TopologyCode.ExcludeCondition"/> of a code for an entity that has that code,
        /// and returns true to exclude the entity from the topology. It receives the entity and the condition, which is a
        /// Python expression. Required when any code of the topology has a non-empty exclusion condition.
        /// </summary>
        public Func<Entity, string, bool> EvaluateExcludeCondition { get => throw null; set => throw null; }
    }
}
