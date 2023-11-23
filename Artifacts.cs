namespace IceCreamTruck.Artifacts
{
    [ArtifactMeta(owner = Deck.colorless, pools = new ArtifactPool[] { ArtifactPool.Boss })]
    public class IceCreamArtifact : Artifact
    {
        public int iceCreamEnergy;
        public int counter;
        public int wingleft_counter;
        public int wingright_counter;
        public int cockpit_counter;
        public int cannon_counter;
        public int missilebay_counter;
        public PDamMod wingleft_pdammod;
        public PDamMod wingright_pdammod;
        public PDamMod cockpit_pdammod;
        public PDamMod cannon_pdammod;
        public PDamMod missilebay_pdammod;
        public int aheat;
        public override void OnTurnEnd(State state, Combat combat)
        {
            this.iceCreamEnergy = combat.energy;
            if (combat.energy >= 0)
            {
                this.Pulse();
            }
        }
        public override void OnTurnStart(State state, Combat combat) => this.GainStoredEnergyAndSpriteChange(state, combat);
        private void GainStoredEnergyAndSpriteChange(State state, Combat combat)
        {
            if (iceCreamEnergy == 0)
            {
                return;
            }
            if (combat.turn == 1)
            {
                foreach (Part part in state.ship.parts)
                {
                    string shippart = part.skin?.Remove(part.skin.Length - 1, 1) ?? throw new Exception();
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted")
                    {
                        this.wingleft_pdammod = part.damageModifier;
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted")
                    {
                        this.wingleft_pdammod = part.damageModifier;
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingRight_Melted")
                    {
                        this.wingright_pdammod = part.damageModifier;
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCockpit_Melted")
                    {
                        this.cockpit_pdammod = part.damageModifier;
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCannon_Melted")
                    {
                        this.cannon_pdammod = part.damageModifier;
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted")
                    {
                        this.missilebay_pdammod = part.damageModifier;
                    }
                };
                goto labelSpriteChange;
            }
            combat.energy += this.iceCreamEnergy;
            this.iceCreamEnergy = 0;
            this.Pulse();
        labelSpriteChange:
            this.aheat = state.ship.statusEffects.GetValueOrDefault(Status.heat, 0);
            if (this.aheat >= 1)
            {
                this.counter += aheat;
                if (combat.turn >= 3)
                {
                    this.counter += 1;
                }
                foreach (Part part in state.ship.parts)
                {
                    string shippart = part.skin?.Remove(part.skin.Length - 1, 1) ?? throw new Exception();
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted" && this.counter >= 2 * (this.wingleft_counter + 2) && this.wingleft_counter != 3)
                    {
                        if (this.wingleft_counter == 3 && this.wingleft_pdammod != part.damageModifier)
                            this.wingleft_pdammod = part.damageModifier;
                        this.wingleft_counter += 1;
                        if (part.skin.EndsWith("Melted3"))
                            break;
                        else
                            part.skin = string.Format("@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted{0}", this.wingleft_counter);
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingRight_Melted" && this.counter >= 3 * (this.wingleft_counter + 2) && this.wingright_counter != 3)
                    {
                        if (this.wingright_counter == 3 && this.wingright_pdammod != part.damageModifier)
                            this.wingright_pdammod = part.damageModifier;
                        this.wingright_counter += 1;
                        if (part.skin.EndsWith("Melted3"))
                            break;
                        else
                            part.skin = string.Format("@mod_part:IceCreamTruck.Parts.IceCreamTruckWingRight_Melted{0}", this.wingright_counter);
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCockpit_Melted" && this.counter >= 5 * (this.cockpit_counter + 2) && this.cockpit_counter != 3)
                    {
                        if (this.cockpit_counter == 3 && this.cockpit_pdammod != part.damageModifier)
                            this.cockpit_pdammod = part.damageModifier;
                        this.cockpit_counter += 1;
                        if (part.skin.EndsWith("Melted3"))
                            break;
                        else
                            part.skin = string.Format("@mod_part:IceCreamTruck.Parts.IceCreamTruckCockpit_Melted{0}", this.cockpit_counter);
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCannon_Melted" && this.counter >= 7 * (this.cannon_counter + 2) && this.cannon_counter != 3)
                    {
                        if (this.cannon_counter == 3 && this.cockpit_pdammod != part.damageModifier)
                            this.cannon_pdammod = part.damageModifier;
                        this.cannon_counter += 1;
                        if (part.skin.EndsWith("Melted3"))
                            break;
                        else
                            part.skin = string.Format("@mod_part:IceCreamTruck.Parts.IceCreamTruckCannon_Melted{0}", this.cannon_counter);
                    }
                    if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted" && this.counter >= 8 * (this.missilebay_counter + 2) && this.missilebay_counter != 3)
                    {
                        if (this.missilebay_counter == 3 && this.missilebay_pdammod != part.damageModifier)
                            this.missilebay_pdammod = part.damageModifier;
                        this.missilebay_counter += 1;
                        if (part.skin.EndsWith("Melted3"))
                            break;
                        else
                            part.skin = string.Format("@mod_part:IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted{0}", this.missilebay_counter);
                    }
                    if (part.skin.StartsWith("@mod_part:IceCreamTruck.Parts.IceCreamTruck") && part.skin.EndsWith("Melted3"))
                    {
                        part.damageModifier = PDamMod.weak;
                    }
                }

            }
        }
        public override void OnCombatEnd(State state) => this.GetPartsToNormal(state);

        private void GetPartsToNormal(State state)
        {
            foreach (Part part in state.ship.parts)
            {
                string shippart = part.skin?.Remove(part.skin.Length - 1, 1) ?? throw new Exception();
                if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted")
                {
                    part.skin = "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted0";
                    part.damageModifier = this.wingleft_pdammod;
                }
                if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingRight_Melted")
                {
                    part.skin = "@mod_part:IceCreamTruck.Parts.IceCreamTruckWingRight_Melted0";
                    part.damageModifier = this.wingright_pdammod;
                }
                if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCockpit_Melted")
                {
                    part.skin = "@mod_part:IceCreamTruck.Parts.IceCreamTruckCockpit_Melted0";
                    part.damageModifier = this.cockpit_pdammod;
                }
                if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckCannon_Melted")
                {
                    part.skin = "@mod_part:IceCreamTruck.Parts.IceCreamTruckCannon_Melted0";
                    part.damageModifier = this.cannon_pdammod;
                }
                if (shippart == "@mod_part:IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted")
                {
                    part.skin = "@mod_part:IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted0";
                    part.damageModifier = this.missilebay_pdammod;
                }
            }

            this.counter = 0;
            this.wingleft_counter = 0;
            this.wingright_counter = 0;
            this.cockpit_counter = 0;
            this.cannon_counter = 0;
            this.missilebay_counter = 0;
        }
    }
}