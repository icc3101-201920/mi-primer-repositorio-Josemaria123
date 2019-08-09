using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Board
    {
        List<CombatCard> meleeCards = new List<CombatCard>();
        List<CombatCard> rangeCards = new List<CombatCard>();
        List<CombatCard> longRangeCards = new List<CombatCard>();
        List<SpecialCard> specialMeleeCards = new List<SpecialCard>();
        List<SpecialCard> specialRangeCards = new List<SpecialCard>();
        List<SpecialCard> specialLongRangeCards = new List<SpecialCard>();
        List<SpecialCard> captainCards = new List<SpecialCard>();
        List<SpecialCard> weatherCards = new List<SpecialCard>();

        private List<CombatCard> MeleeCards { get; set; }
        private List<CombatCard> RangeCards { get; set; }
        private List<CombatCard> RangeCards { get; set; }
        private List<CombatCard>  LongRangeCards { get; set; }
        private SpecialCard SpecialMeleeCards { get; set; }
        private SpecialCard SpecialRangeCards { get; set; }
        private SpecialCard SpecialLongRangeCards { get; set; }
        private List<SpecialCard> CaptainCards { get; set; }
        private List<SpecialCard> WeatherCards { get; set; }

        public void AddComnatCard(int playerId, CombatCard combatCard)
        {

        }
        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {

        }
        public void DestroyCombatCards()
        {

        }
        public void DestroySpecialCards()
        {

        }
        public int GetMeleeAttackPoints()
        {

        }
        public int GetRangeAttackPoints()
        {

        }
        public int GetLongRangeAttackPoints()
        {

        }
    }
}
