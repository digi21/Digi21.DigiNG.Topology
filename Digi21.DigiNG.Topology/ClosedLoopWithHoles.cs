using System.Collections.Generic;

namespace Digi21.DigiNG.Topology
{
    public class ClosedLoopWithHoles : ClosedLoop
    {
        public ClosedLoopWithHoles() { throw null; }
        public List<ClosedLoop> Holes { get; }
    }
}
