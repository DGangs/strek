using System;

namespace StarTrekGame
{
    public class Shield
    {

        public const int SHIELD_MAX = 10000;
        public const int SHIELD_DEFAULT = 8000;

        private int power = SHIELD_DEFAULT;
        private bool isUp = false;

        public bool IsUp()
        {
            return false;
        }

        public void Raise()
        {
            isUp = true;
        }

        public int GetCurrentEnergyLevel()
        {
            return power;
        }

        public bool GetIsUp()
        {
            return isUp;
        }

        public void AddEnergy(int amountOfPowerToAdd)
        {
            power += amountOfPowerToAdd;
            if(power > SHIELD_MAX)
            {
                power = SHIELD_MAX;
            }
        }
    }
}