using Digi21.DigiNG.DigiTab;
using Digi21.DigiNG.Entities;
using Digi21.Math;
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
        /// <summary>
        /// Builds a topology from <paramref name="entities"/> using the code table topology definition specified by <paramref name="topology"/>, as the BINTOP=#name command does.
        /// </summary>
        /// <param name="entities">Entities to analyze. Only the entities that are not deleted, not hidden and not outside the area of interest, and have a code of the topology, take part in it.</param>
        /// <param name="topology">Topology definition that provides the codes, the 3D continuity requirement and the hole centroid text.</param>
        /// <returns>
        /// The valid polygons that are not holes, each one with its holes and its centroid, or with a null centroid if it does not
        /// contain any. The collection is empty if no entity has a code of the topology or no polygon is formed.
        /// </returns>
        /// <remarks>
        /// The returned polygons keep references to the entities passed in <paramref name="entities"/>, and
        /// <see cref="CreatePolygon"/> reads the native coordinates of the entities passed in <paramref name="entities"/>: do not dispose those entities, nor the drawing file
        /// they were read from, while the polygons are in use.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException"><paramref name="entities"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException">A code of the topology has an exclusion condition, which needs <see cref="TopologyAnalysisHandlers.EvaluateExcludeCondition"/>, or <paramref name="entities"/> contains a null element.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        /// <exception cref="System.Exception">A line's first two or last two vertices have equal X and Y coordinates, or an entity is a point or a line with fewer than two vertices.</exception>
        public static IEnumerable<ClosedLoopWithHoles> AnalyzeTopology(this IEnumerable<Entity> entities, TopologyDefinition topology) => throw null;
        /// <summary>
        /// Builds a topology from <paramref name="entities"/> using the code table topology definition specified by <paramref name="topology"/>, as the BINTOP=#name command does,
        /// and reports the errors found to the delegates of <paramref name="handlers"/>.
        /// </summary>
        /// <param name="entities">Entities to analyze. Only the entities that are not deleted, not hidden and not outside the area of interest, and have a code of the topology, take part in it.</param>
        /// <param name="topology">Topology definition that provides the codes, the 3D continuity requirement and the hole centroid text.</param>
        /// <param name="handlers">Delegates that receive progress and error notifications and evaluate exclusion conditions. <paramref name="handlers"/> can be null. An exception thrown by a delegate does not interrupt the analysis: <see cref="AnalyzeTopology"/> stops invoking delegates and rethrows the exception when the native analysis finishes.</param>
        /// <returns>
        /// The valid polygons that are not holes, each one with its holes and its centroid, or with a null centroid if it does not
        /// contain any. The collection is empty if no entity has a code of the topology or no polygon is formed.
        /// </returns>
        /// <remarks>
        /// The returned polygons keep references to the entities passed in <paramref name="entities"/>, and
        /// <see cref="CreatePolygon"/> reads the native coordinates of the entities passed in <paramref name="entities"/>: do not dispose those entities, nor the drawing file
        /// they were read from, while the polygons are in use.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException"><paramref name="entities"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException">A code of the topology has an exclusion condition and <paramref name="handlers"/> or its <see cref="TopologyAnalysisHandlers.EvaluateExcludeCondition"/> is null, or <paramref name="entities"/> contains a null element.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        /// <exception cref="System.Exception">A line's first two or last two vertices have equal X and Y coordinates, or an entity is a point or a line with fewer than two vertices. The corresponding non-null notification delegate receives each affected entity before <see cref="AnalyzeTopology"/> throws.</exception>
        public static IEnumerable<ClosedLoopWithHoles> AnalyzeTopology(this IEnumerable<Entity> entities, TopologyDefinition topology, TopologyAnalysisHandlers handlers) => throw null;
        /// <summary>
        /// Creates the polygon that a topology definition of the code table generates for a closed loop, as the TOPOLOGIA_A_POLIGONO command does.
        /// When a topology Z coordinate rule requires projection onto a digital terrain model (DTM), this overload of <see cref="CreatePolygon"/> preserves each vertex's original Z coordinate.
        /// </summary>
        /// <param name="loop">Closed loop with centroid returned by <see cref="AnalyzeTopology"/>.</param>
        /// <param name="topology">Topology definition that provides the polygon code, the Z coordinate rules and the hole centroid text.</param>
        /// <returns>A new polygon that does not belong to any drawing file. Add it to a file with <c>IDrawingFile.Add(Polygon)</c> and dispose it when it is no longer needed.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="loop"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="loop"/> has no centroid, its centroid has no code, its centroid text is <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.HoleCentroidText"/>, or a ring has no lines or a line with fewer than two vertices.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        public static Polygon CreatePolygon(this ClosedLoopWithHoles loop, TopologyDefinition topology) => throw null;
        /// <summary>
        /// Creates the polygon that a topology definition of the code table generates for a closed loop, as the TOPOLOGIA_A_POLIGONO command does.
        /// </summary>
        /// <param name="loop">Closed loop with centroid returned by <see cref="AnalyzeTopology"/>.</param>
        /// <param name="topology">Topology definition that provides the polygon code, the Z coordinate rules and the hole centroid text.</param>
        /// <param name="projectZ">
        /// Returns the Z coordinate of a point on a digital terrain model (DTM), or null if no DTM contains the point. <see cref="CreatePolygon"/> uses
        /// <paramref name="projectZ"/> for Z coordinate rules that require DTM projection, without passing a DTM tag. If <paramref name="projectZ"/> is null or returns null, <see cref="CreatePolygon"/> preserves the vertex's original Z coordinate.
        /// </param>
        /// <returns>A new polygon that does not belong to any drawing file. Add it to a file with <c>IDrawingFile.Add(Polygon)</c> and dispose it when it is no longer needed.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="loop"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="loop"/> has no centroid, its centroid has no code, its centroid text is <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.HoleCentroidText"/>, or a ring has no lines or a line with fewer than two vertices.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        public static Polygon CreatePolygon(this ClosedLoopWithHoles loop, TopologyDefinition topology, Func<Point3D, double?> projectZ) => throw null;
        /// <summary>
        /// Creates the polygon that a topology definition of the code table generates for a closed loop, as the TOPOLOGIA_A_POLIGONO command does.
        /// </summary>
        /// <param name="loop">Closed loop with centroid returned by <see cref="AnalyzeTopology"/>.</param>
        /// <param name="topology">Topology definition that provides the polygon code, the Z coordinate rules and the hole centroid text.</param>
        /// <param name="projectZ">
        /// Returns the Z coordinate of a point on the digital terrain models (DTM) with a tag, or null if none of them contains the point.
        /// The <paramref name="projectZ"/> delegate receives the point and the DTM tag specified by the Z coordinate rule; an empty tag means any DTM. <see cref="CreatePolygon"/> uses
        /// <paramref name="projectZ"/> for Z coordinate rules that require DTM projection. If <paramref name="projectZ"/> is null or returns null, <see cref="CreatePolygon"/> preserves the vertex's original Z coordinate.
        /// </param>
        /// <returns>A new polygon that does not belong to any drawing file. Add it to a file with <c>IDrawingFile.Add(Polygon)</c> and dispose it when it is no longer needed.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="loop"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="loop"/> has no centroid, its centroid has no code, its centroid text is <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.HoleCentroidText"/>, or a ring has no lines or a line with fewer than two vertices.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        public static Polygon CreatePolygon(this ClosedLoopWithHoles loop, TopologyDefinition topology, Func<Point3D, string, double?> projectZ) => throw null;
        /// <summary>
        /// Creates the polygons that a topology definition of the code table generates for some closed loops, as the TOPOLOGIA_A_POLIGONO command does.
        /// The loops without centroid and the loops whose centroid text is <see cref="Digi21.DigiNG.DigiTab.TopologyDefinition.HoleCentroidText"/> are skipped.
        /// </summary>
        /// <param name="loops">Closed loops returned by <see cref="AnalyzeTopology"/>.</param>
        /// <param name="topology">Topology definition that provides the polygon code, the Z coordinate rules and the hole centroid text.</param>
        /// <param name="projectZ">
        /// Returns the Z coordinate of a point on the digital terrain models (DTM) with a tag, or null if none of them contains the point.
        /// The <paramref name="projectZ"/> delegate receives the point and the DTM tag specified by the Z coordinate rule; an empty tag means any DTM. <see cref="CreatePolygons"/> uses
        /// <paramref name="projectZ"/> for Z coordinate rules that require DTM projection. If <paramref name="projectZ"/> is null or returns null, <see cref="CreatePolygons"/> preserves the corresponding vertex's original Z coordinate.
        /// </param>
        /// <returns>New polygons that do not belong to any drawing file, in the order of <paramref name="loops"/>. Add them to a file with <c>IDrawingFile.Add(Polygon)</c> and dispose them when they are no longer needed.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="loops"/> or <paramref name="topology"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="loops"/> contains a null element, the centroid of a loop has no code, or a ring has no lines or a line with fewer than two vertices.</exception>
        /// <exception cref="System.ObjectDisposedException"><paramref name="topology"/> has been disposed.</exception>
        public static IReadOnlyList<Polygon> CreatePolygons(this IEnumerable<ClosedLoopWithHoles> loops, TopologyDefinition topology, Func<Point3D, string, double?> projectZ) => throw null;
    }
}
