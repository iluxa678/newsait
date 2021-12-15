using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class PositionStorage
    {
        private Dictionary<int, Position> Positions { get; } = new Dictionary<int, Position>();

        public void Create(Position position)
        {
            Positions.Add(position.PositionId, position);
        }

        public Position Read(int PositionId)
        {
            return Positions[PositionId];
        }

        public Position Update(int PositionId, Position newPosition)
        {
            Positions[PositionId] = newPosition;
            return Positions[PositionId];
        }

        public bool Delete(int PositionId)
        {
            return Positions.Remove(PositionId);
        }
    }
}