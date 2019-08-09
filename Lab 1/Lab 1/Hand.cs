using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Hand
    {
        List<CombatCard> combatCards = new List<CombatCard>();
        List<SpecialCard> specialCards = new List<SpecialCard>();

        private List<CombatCard> CombatCards { get; set; }
        private List<SpecialCard> SpecialCards { get; set; }

        public void AddCombatCard(CombatCard combatCard)
        {

        }
        public void AddSpecialCard(SpecialCard specialCard)
        {

        }
        public void DestroyCombatCard(int cardId)
        {

        }
        public void DestroySpecialCard(int cardId)
        {

        }
    }
}
