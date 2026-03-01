using System;

namespace APPR_TheRace_24SD_BPRJ_S2
{
    public class csRacerBase
    {
        // ==================== PROPERTIES ====================
        public string racerName { get; set; }
        public bool racerFinished { get; set; }
        public string version = "v1.2";

        private double tuningSpeed;
        private double stepSizePerTick;
        private double actualPositionInLane;
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());

        // ==================== GETTERS ====================
        public int GetTunedRacerSpeed => (int)tuningSpeed;
        public double GetStepSizePerTick => stepSizePerTick;
        public int GetActualPositionInLaneRounded => (int)Math.Round(actualPositionInLane);

        // ==================== METHODS ====================

        // Requirement: Set random speed within range
        public void setSpeed(int min, int max)
        {
            tuningSpeed = rnd.Next(min, max);
        }

        // Requirement: Calculate step based on lane length
        public void calculateStepSize(int laneLength)
        {
            // Simple logic to convert speed to a movement step
            stepSizePerTick = (tuningSpeed / 1000.0) * (laneLength / 100.0);
        }

        // Requirement: Smooth movement logic
        public void calculateCurrentPosition()
        {
            if (!racerFinished)
            {
                actualPositionInLane += stepSizePerTick;
            }
        }

        // Requirement: Reset to absolute starting state
        public void resetPosition(int startValue)
        {
            actualPositionInLane = startValue;
            racerFinished = false;
        }
    }
}
