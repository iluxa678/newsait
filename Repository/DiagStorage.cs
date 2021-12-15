using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class DiagStorage
    {
        private Dictionary<int, Diag> Diags { get; } = new Dictionary<int, Diag>();

        public void Create(Diag diag)
        {
            Diags.Add(diag.DiagId, diag);
        }

        public Diag Read(int DiagId)
        {
            return Diags[DiagId];
        }

        public Diag Update(int DiagId, Diag newDiag)
        {
            Diags[DiagId] = newDiag;
            return Diags[DiagId];
        }

        public bool Delete(int DiagId)
        {
            return Diags.Remove(DiagId);
        }
    }
}