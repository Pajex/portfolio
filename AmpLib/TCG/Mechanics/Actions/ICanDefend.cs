﻿using AmpLib.TCG.Cards;

namespace AmpLib.TCG.Mechanics.Actions
{
    public interface ICanDefend
    {
        /// <summary>
        /// Calculates the amount of damage dealt to a card.
        /// </summary>
        /// <param name="attacker">The card that is attacking.</param>
        /// <param name="defender">The card that is defending.</param>
        /// <returns>The amount of damage dealt to the card.</returns>
        int Defend(MinionCard defender);
    }
}