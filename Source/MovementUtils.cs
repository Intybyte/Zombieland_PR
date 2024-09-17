using Verse;

namespace ZombieLand
{
    internal class MovementUtils
    {
        public static float MovedPercent(Pawn pawn)
        {
            if (pawn.pather.Moving)
            {
                return 0f;
            }
            if (pawn.stances.FullBodyBusy)
            {
                return 0f;
            }
            if (pawn.pather.BuildingBlockingNextPathCell() != null)
            {
                return 0f;
            }
            if (pawn.pather.NextCellDoorToWaitForOrManuallyOpen() != null)
            {
                return 0f;
            }
            if (pawn.pather.WillCollideNextCell)
            {
                return 0f;
            }
            return 1f - pawn.pather.nextCellCostLeft / pawn.pather.nextCellCostTotal;
        }
    }
}
