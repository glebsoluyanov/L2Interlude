﻿namespace Core.Module.CharacterData.Template.Race
{
    public abstract class Human
    {
        private const byte RaceId = 0;

        public byte GetRaceId()
        {
            return RaceId;
        }
    }
}