using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.Topology
{
    public class ClosedLoop
    {
        public ClosedLoop() { throw null; }
        public Polygon Polygon { get; }
        public ReadOnlyText Centroid { get; }
        public List<Tuple<ReadOnlyLine, bool>> Entities { get; }
    }
}
