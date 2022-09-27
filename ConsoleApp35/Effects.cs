using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    abstract class Effect
    {
        public Effect(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract string GetEffect();
    }
    class MagicHeal : Effect
    {
        public MagicHeal() : base("Magic Heal")
        { }
        public override string GetEffect()
        {
            return "Magic Heal cast";
        }
    }
    class MagicalBurning : Effect
    {
        public MagicalBurning()
            : base("Magical Burning")
        { }
        public override string GetEffect()
        {
            return "Magical Burning cast";
        }
    }
    
    abstract class EffectDecorator : Effect
    {
        protected Effect effect;
        public EffectDecorator(string n, Effect effect) : base(n)
        {
            this.effect = effect;
        }
    }
    class AutoSpell : EffectDecorator
    {
        public AutoSpell(Effect p)
            : base(p.Name + ", Auto Heal", p)
        { }

        public override string GetEffect()
        {
            return effect.GetEffect() + ("healing field");
        }
    }
    class AutoCast : EffectDecorator
    {
        public AutoCast(Effect p)
            : base(p.Name + ", Automatical Cast", p)
        { }

        public override string GetEffect()
        {
            return effect.GetEffect() + ("Fire Burning");
        }
    }
}
