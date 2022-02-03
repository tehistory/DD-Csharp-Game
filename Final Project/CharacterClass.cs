using System;
using System.Linq;

/// <summary>
///     This defines any character.
/// </summary>
namespace DnDGame
{ 
    public class Character
    {
        //
        private string _charName;
        private string _backgroundTrait;
        private string _professionTrait;

        //stats
        private int _hitPoints;
        private int _strengthStat;
        private int _dexterityStat;
        private int _constitutionStat;
        private int _intelligenceStat;
        private int _wisdomStat;
        private int _charismaStat;

        //Modifer Calculator
        public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2.0);

        //Begining of Stat getters and setters
        public string CharName
        {
            get { return _charName; }
            set { _charName = value; }
        }
        public string Background
        {
            get { return _backgroundTrait; }
            private set { _backgroundTrait = value; }
        }
        public string Profession
        {
            get { return _professionTrait; }
            private set { _professionTrait = value; }
        }
        public int HitPoints
        {
            get { return _hitPoints; }
            private set { _hitPoints = value; }
        }
        public int Strength
        {
            get { return _strengthStat; }
            private set { _strengthStat = value; }
        }
        public int Dexterity
        {
            get { return _dexterityStat; }
            private set { _dexterityStat = value; }
        }
        public int Constitution
        {
            get { return _constitutionStat; }
            private set { _constitutionStat = value; }
        }
        public int Intelligence
        {
            get { return _intelligenceStat; }
            private set { _intelligenceStat = value; }
        }
        public int Wisdom
        {
            get { return _wisdomStat; }
            private set { _wisdomStat = value; }
        }
        public int Charisma
        {
            get { return _charismaStat; }
            private set { _charismaStat = value; }
        }
        //skills
        private int _acrobaticsMod;
        private int _animalHandlingMod;
        private int _arcanaMod;
        private int _athleticsMod;
        private int _deceptionMod;
        private int _historyMod;
        private int _insightMod;
        private int _intimidationMod;
        private int _medicineMod;
        private int _natureMod;
        private int _perceptionMod;
        private int _performanceMod;
        private int _persuasionMod;
        private int _religonMod;
        private int _slightOfHandMod;
        private int _stealthMod;
        private int _survivalMod;

        public int Acrobatics
        {
            get { return _acrobaticsMod; }
            private set { _acrobaticsMod = value; }
        }
        public int AnimalHandling
        {
            get { return _animalHandlingMod; }
            private set { _animalHandlingMod = value; }
        }
        public int Arcana
        {
            get { return _arcanaMod; }
            private set { _arcanaMod = value; }
        }
        public int Athletics
        {
            get { return _athleticsMod; }
            private set { _athleticsMod = value; }
        }
        public int Deception
        {
            get { return _deceptionMod; }
            private set { _deceptionMod = value; }
        }
        public int History
        {
            get { return _historyMod; }
            private set { _historyMod = value; }
        }
        public int Insight
        {
            get { return _insightMod; }
            private set { _insightMod = value; }
        }
        public int Intimidation
        {
            get { return _intimidationMod; }
            private set { _intimidationMod = value; }
        }
        public int Medicine
        {
            get { return _medicineMod; }
            private set { _medicineMod = value; }
        }
        public int Nature
        {
            get { return _natureMod; }
            private set { _natureMod = value; }
        }
        public int Perception
        {
            get { return _perceptionMod; }
            private set { _perceptionMod = value; }
        }
        public int Performance
        {
            get { return _performanceMod; }
            private set { _performanceMod = value; }
        }
        public int Persuasion
        {
            get { return _persuasionMod; }
            private set { _persuasionMod = value; }
        }
        public int Religon
        {
            get { return _religonMod; }
            private set { _religonMod = value; }
        }
        public int SlightOfHand
        {
            get { return _slightOfHandMod; }
            private set { _slightOfHandMod = value; }
        }
        public int Stealth
        {
            get { return _stealthMod; }
            private set { _stealthMod = value; }
        }
        public int Survival
        {
            get { return _survivalMod; }
            private set { _survivalMod = value; }
        }

        ////crafting
        //private int _alchemyMod;
        //private int _poisonCraftMod;
        //private int _blackSmithMod;
        //private int _cookingMod;
        //private int _enchantingMod;
        //private int _scrollScribeMod;
        //private int _wandMakerMod;
        //private int _tinkerMod;
        //private int _woodcarvingMod;
        //private int _runecarvingMod;
        //private int _engineeringMod;
    
        ////minorcrafting??
        //private int _weavingMod;
        //private int _cobblingMod;
        //private int _masonryMod;
        //private int _glassBlowingMod;
        //private int _paintingMod;
        //private int _brewingMod;
        //private int _jewelCraftingMod;
        //private int _carpentryMod;
        //private int _tailoringMod;

        //End of Stat getters and setters

        //Make our "Dice" that were going to roll
        private static readonly Random random = new Random();

        //We need to roll four "6 sided dice", drop the lowest roll, then add them together to form a new score
        public static int AbilityScoreRoll()
        {
            int[] abilityPoints = new int[4];

            for (int i = 0; i < 4; i++)
            {
                abilityPoints[i] = random.Next(1, 7);
            }
            return abilityPoints.OrderBy(x => x).Skip(1).Take(3).Sum();
        }

        //Lets get some stats!

        public Character()
        {
            Strength = AbilityScoreRoll();
            Dexterity = AbilityScoreRoll();
            Constitution = AbilityScoreRoll();
            Intelligence = AbilityScoreRoll();
            Wisdom = AbilityScoreRoll();
            Charisma = AbilityScoreRoll();
            HitPoints = 10 + Modifier(Constitution);
            Acrobatics = Modifier(Dexterity);
            AnimalHandling = Modifier(Wisdom);
            Arcana = Modifier(Intelligence);
            Athletics = Modifier(Strength);
            Deception = Modifier(Charisma);
            History = Modifier(Intelligence);
            Insight = Modifier(Wisdom);
            Intimidation = Modifier(Charisma);
            Medicine = Modifier(Wisdom);
            Nature = Modifier(Intelligence);
            Perception = Modifier(Wisdom);
            Performance = Modifier(Charisma);
            Persuasion = Modifier(Charisma);
            Religon = Modifier(Intelligence);
            SlightOfHand = Modifier(Dexterity);
            Stealth = Modifier(Dexterity);
            Survival = Modifier(Wisdom);
        }
    }
}
