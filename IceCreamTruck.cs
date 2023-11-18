using CobaltCoreModding.Definitions.ExternalItems;
using CobaltCoreModding.Definitions.ModContactPoints;
using CobaltCoreModding.Definitions.ModManifests;
using IceCreamTruck.Artifacts;
namespace IceCreamTruck
{
    public class Manifest :
    ISpriteManifest,
    IManifest,
    IDeckManifest,
    //ICharacterManifest,
    //IAnimationManifest,
    //IStatusManifest,
    IArtifactManifest,
    IShipPartManifest,
    IShipManifest,
    IStartershipManifest
    {
        private static System.Drawing.Color IceCreamTruck_Primary_Color = System.Drawing.Color.FromArgb(255, 143, 171);
        public static ExternalArtifact? IceCreamArtifact { get; private set; }
        public static ExternalDeck? IceCreamTruckDeck { get; private set; }
        //public static ExternalCharacter? IceCreamTruck_Character { get; private set; }
        //public static ExternalAnimation? IceCreamTruck_CharacterDefaultAnimation { get; private set; }
        //public static ExternalAnimation? IceCreamTruck_CharacterMiniAnimation { get; private set; }
        //public static ExternalAnimation? GameoverCharacterAnimation { get; private set; }
        //public static ExternalSprite? IceCreamTruck_CharacterMini_Sprite { get; private set; }
        //public static ExternalSprite? IceCreamTruck_CharacterPortrait_Sprite { get; private set; }
        //public static ExternalSprite? IceCreamTruck_CardFrame { get; private set; }
        //public static ExternalSprite? IceCreamTruck_CharacterPanelFrame { get; private set; }
        public static ExternalSprite? IceCreamTruck_CardFrame { get; private set; }
        public static ExternalSprite? IceCreamArtifact_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cannon_Melted0_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cannon_Melted1_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cannon_Melted2_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cannon_Melted3_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_MissileBay_Melted0_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_MissileBay_Melted1_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_MissileBay_Melted2_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_MissileBay_Melted3_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cockpit_Melted0_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cockpit_Melted1_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cockpit_Melted2_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Cockpit_Melted3_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_WingLeft_Melted0_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_WingLeft_Melted1_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_WingLeft_Melted2_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_WingLeft_Melted3_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Scaffolding_Sprite { get; private set; }
        public static ExternalSprite? IceCreamTruck_Chassis_Sprite { get; private set; }
        public static ExternalPart? IceCreamTruck_Cannon_Melted0 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cannon_Melted1 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cannon_Melted2 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cannon_Melted3 { get; private set; }
        public static ExternalPart? IceCreamTruck_MissileBay_Melted0 { get; private set; }
        public static ExternalPart? IceCreamTruck_MissileBay_Melted1 { get; private set; }
        public static ExternalPart? IceCreamTruck_MissileBay_Melted2 { get; private set; }
        public static ExternalPart? IceCreamTruck_MissileBay_Melted3 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cockpit_Melted0 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cockpit_Melted1 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cockpit_Melted2 { get; private set; }
        public static ExternalPart? IceCreamTruck_Cockpit_Melted3 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingLeft_Melted0 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingLeft_Melted1 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingLeft_Melted2 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingLeft_Melted3 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingRight_Melted0 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingRight_Melted1 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingRight_Melted2 { get; private set; }
        public static ExternalPart? IceCreamTruck_WingRight_Melted3 { get; private set; }
        public static ExternalPart? IceCreamTruck_Scaffolding { get; private set; }
        public static ExternalPart? IceCreamTruck_Chassis { get; private set; }
        public static ExternalShip? IceCreamTruck_Ship { get; private set; }
        public static ExternalStarterShip? IceCreamTruck_StarterShip { get; private set; }
        IEnumerable<string> ISpriteManifest.Dependencies => (IEnumerable<string>)new string[0];
        public DirectoryInfo? ModRootFolder { get; set; }
        public string Name { get; init; } = "Sorwest.IceCreamTruck";
        public DirectoryInfo? GameRootFolder { get; set; }
        void ISpriteManifest.LoadManifest(IArtRegistry artRegistry)
        {
            Manifest.IceCreamTruck_Cannon_Melted0_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted0_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted0_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cannon_Melted0_Sprite, new int?());
            Manifest.IceCreamTruck_Cannon_Melted1_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted1_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted1_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cannon_Melted1_Sprite, new int?());
            Manifest.IceCreamTruck_Cannon_Melted2_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted2_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted2_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cannon_Melted2_Sprite, new int?());
            Manifest.IceCreamTruck_Cannon_Melted3_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted3_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted3_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cannon_Melted3_Sprite, new int?());

            Manifest.IceCreamTruck_MissileBay_Melted0_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted0_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted0_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_MissileBay_Melted0_Sprite, new int?());
            Manifest.IceCreamTruck_MissileBay_Melted1_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted1_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted1_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_MissileBay_Melted1_Sprite, new int?());
            Manifest.IceCreamTruck_MissileBay_Melted2_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted2_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted2_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_MissileBay_Melted2_Sprite, new int?());
            Manifest.IceCreamTruck_MissileBay_Melted3_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted3_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted3_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_MissileBay_Melted3_Sprite, new int?());

            Manifest.IceCreamTruck_Cockpit_Melted0_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted0_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted0_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cockpit_Melted0_Sprite, new int?());
            Manifest.IceCreamTruck_Cockpit_Melted1_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted1_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted1_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cockpit_Melted1_Sprite, new int?());
            Manifest.IceCreamTruck_Cockpit_Melted2_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted2_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted2_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cockpit_Melted2_Sprite, new int?());
            Manifest.IceCreamTruck_Cockpit_Melted3_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted3_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted3_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Cockpit_Melted3_Sprite, new int?());

            Manifest.IceCreamTruck_WingLeft_Melted0_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted0_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted0_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_WingLeft_Melted0_Sprite, new int?());
            Manifest.IceCreamTruck_WingLeft_Melted1_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted1_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted1_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_WingLeft_Melted1_Sprite, new int?());
            Manifest.IceCreamTruck_WingLeft_Melted2_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted2_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted2_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_WingLeft_Melted2_Sprite, new int?());
            Manifest.IceCreamTruck_WingLeft_Melted3_Sprite = this.ModRootFolder != null ? new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted3_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted3_Sprite.png")))) : throw new Exception("Root Folder not set");
            artRegistry.RegisterArt(Manifest.IceCreamTruck_WingLeft_Melted3_Sprite, new int?());

            Manifest.IceCreamTruck_Scaffolding_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Scaffolding_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Scaffolding_Sprite.png"))));
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Scaffolding_Sprite, new int?());
            Manifest.IceCreamTruck_Chassis_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Chassis_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Chassis_Sprite.png"))));
            artRegistry.RegisterArt(Manifest.IceCreamTruck_Chassis_Sprite, new int?());
            Manifest.IceCreamTruck_CardFrame = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_CardFrame_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_CardFrame_Sprite.png"))));
            artRegistry.RegisterArt(Manifest.IceCreamTruck_CardFrame, new int?());
            //Manifest.IceCreamTruck_CharacterPortrait_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_CharacterPortrait_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_CharacterPortrait_Sprite.png"))));
            //artRegistry.RegisterArt(Manifest.IceCreamTruck_CharacterPortrait_Sprite, new int?());
            //Manifest.IceCreamTruck_CharacterMini_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_CharacterMini_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_CharacterMini_Sprite.png"))));
            //artRegistry.RegisterArt(Manifest.IceCreamTruck_CharacterMini_Sprite, new int?());
            //Manifest.IceCreamTruck_CharacterPanelFrame = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_CharacterPanelFrame_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_CharacterPanelFrame_Sprite.png"))));
            //artRegistry.RegisterArt(Manifest.IceCreamTruck_CharacterPanelFrame, new int?());
            Manifest.IceCreamArtifact_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_IceCreamArtifact_Sprite", new FileInfo(Path.Combine(this.ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_IceCreamArtifact_Sprite.png"))));
            artRegistry.RegisterArt(Manifest.IceCreamArtifact_Sprite, new int?());
        }
        public void LoadManifest(IDeckRegistry registry)
        {
            ExternalSprite raw = ExternalSprite.GetRaw(480);
            ExternalSprite externalSprite = Manifest.IceCreamTruck_CardFrame ?? throw new Exception();
            Manifest.IceCreamTruckDeck = new ExternalDeck("IceCreamTruck.IceCreamTruckDeck", Manifest.IceCreamTruck_Primary_Color, System.Drawing.Color.Black, raw, externalSprite, (ExternalSprite)null);
            registry.RegisterDeck(Manifest.IceCreamTruckDeck, new int?());
        }
        public void LoadManifest(IArtifactRegistry registry)
        {
            Type type1 = typeof(IceCreamArtifact);
            ExternalSprite iceCreamArtifact = Manifest.IceCreamArtifact_Sprite;
            if (iceCreamArtifact == null)
                throw new Exception("missing icecream sprite");
            ExternalDeck icecreamtruckdeck1 = Manifest.IceCreamTruckDeck;
            if (icecreamtruckdeck1 == null)
                throw new Exception("missing icecream deck.");
            ExternalGlossary[] externalGlossaryArray1 = new ExternalGlossary[0];
            Manifest.IceCreamArtifact = new ExternalArtifact(type1, "IceCreamTruck.Artifacts.IceCream", IceCreamArtifact_Sprite, icecreamtruckdeck1, (IEnumerable<ExternalGlossary>)externalGlossaryArray1);
            Manifest.IceCreamArtifact.AddLocalisation("en", "ICE CREAM", "Unused <c=energy>ENERGY</c> is regained at the beginning of the next turn.");
            registry.RegisterArtifact(Manifest.IceCreamArtifact, (string?)null);
        }
        //void ICharacterManifest.LoadManifest(ICharacterRegistry registry)
        //{
        //    ExternalDeck iceCreamTruckDeck = Manifest.IceCreamTruckDeck;
        //    if (iceCreamTruckDeck == null)
        //        throw new Exception("Missing Deck");
        //    ExternalSprite iceCreamTruckPanelFrame = Manifest.IceCreamTruck_CharacterPanelFrame;
        //    if (iceCreamTruckPanelFrame == null)
        //        throw new Exception("Missing Potrait");
        //    Type[] starterDeck = new Type[0];
        //    Type[] starterArtifacts = new Type[0];
        //    Manifest.IceCreamTruck_Character = new ExternalCharacter("IceCreamTruck.Character.FoxLad", IceCreamTruckDeck, IceCreamTruck_CharacterPanelFrame, (IEnumerable<Type>)starterDeck, (IEnumerable<Type>)starterArtifacts, Manifest.IceCreamTruck_CharacterDefaultAnimation ?? throw new Exception("missing default animation"), Manifest.IceCreamTruck_CharacterMiniAnimation ?? throw new Exception("missing mini animation"));
        //    Manifest.IceCreamTruck_Character.AddNameLocalisation("Fox Lad", "en");
        //    Manifest.IceCreamTruck_Character.AddDescLocalisation("<c=riggs>FOXLAD</c>\nAn old friend of Drake, Fox Lad wants to break free from the loop and discover new flavors.", "en");
        //    registry.RegisterCharacter(Manifest.IceCreamTruck_Character);
        //}
        //void IAnimationManifest.LoadManifest(IAnimationRegistry registry)
        //{
        //    ExternalDeck iceCreamTruckDeck1 = Manifest.IceCreamTruckDeck;
        //    if (iceCreamTruckDeck1 == null)
        //        throw new Exception("missing deck");
        //    ExternalSprite[] frames1 = new ExternalSprite[1];
        //    frames1[0] = Manifest.IceCreamTruck_CharacterPortrait_Sprite ?? throw new Exception("missing portrait");
        //    Manifest.IceCreamTruck_CharacterDefaultAnimation = new ExternalAnimation("IceCreamTruckTheTrucker.Animation.IceCreamTruckDefault", iceCreamTruckDeck1, "neutral", false, (IEnumerable<ExternalSprite>)frames1);
        //    registry.RegisterAnimation(Manifest.IceCreamTruck_CharacterDefaultAnimation);
        //    ExternalDeck iceCreamTruckDeck2 = Manifest.IceCreamTruckDeck;
        //    if (iceCreamTruckDeck2 == null)
        //        throw new Exception("missing deck");
        //    ExternalSprite[] frames2 = new ExternalSprite[1];
        //    frames2[0] = Manifest.IceCreamTruck_CharacterMini_Sprite ?? throw new Exception("missing mini");
        //    Manifest.IceCreamTruck_CharacterMiniAnimation = new ExternalAnimation("IceCreamTruckTheTrucker.Animation.IceCreamTruckMini", iceCreamTruckDeck2, "mini", false, (IEnumerable<ExternalSprite>)frames2);
        //    registry.RegisterAnimation(Manifest.IceCreamTruck_CharacterMiniAnimation);
        //    ExternalDeck iceCreamTruckDeck3 = Manifest.IceCreamTruckDeck;
        //    if (iceCreamTruckDeck3 == null)
        //        throw new Exception("missing deck");
        //    ExternalSprite[] frames3 = new ExternalSprite[1];
        //    frames3[0] = Manifest.IceCreamTruck_CharacterPortrait_Sprite ?? throw new Exception("missing portrait");
        //    Manifest.GameoverCharacterAnimation = new ExternalAnimation("IceCreamTruckTheTrucker.Animation.GameOver", iceCreamTruckDeck2, "gameover", false, (IEnumerable<ExternalSprite>)frames3);
        //    registry.RegisterAnimation(Manifest.GameoverCharacterAnimation);
        //}
        public void LoadManifest(IShipPartRegistry registry)
        {
            Part icecreamtruckcannon_melted0 = new Part();
            icecreamtruckcannon_melted0.active = true;
            icecreamtruckcannon_melted0.type = PType.cannon;
            icecreamtruckcannon_melted0.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cannon_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted0", (object)icecreamtruckcannon_melted0, Manifest.IceCreamTruck_Cannon_Melted0_Sprite ?? throw new Exception());
            Part icecreamtruckcannon_melted1 = new Part();
            icecreamtruckcannon_melted1.active = true;
            icecreamtruckcannon_melted1.type = PType.cannon;
            icecreamtruckcannon_melted1.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cannon_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted1", (object)icecreamtruckcannon_melted1, Manifest.IceCreamTruck_Cannon_Melted1_Sprite ?? throw new Exception());
            Part icecreamtruckcannon_melted2 = new Part();
            icecreamtruckcannon_melted2.active = true;
            icecreamtruckcannon_melted2.type = PType.cannon;
            icecreamtruckcannon_melted2.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cannon_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted2", (object)icecreamtruckcannon_melted2, Manifest.IceCreamTruck_Cannon_Melted2_Sprite ?? throw new Exception());
            Part icecreamtruckcannon_melted3 = new Part();
            icecreamtruckcannon_melted3.active = true;
            icecreamtruckcannon_melted3.type = PType.cannon;
            icecreamtruckcannon_melted3.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cannon_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted3", (object)icecreamtruckcannon_melted3, Manifest.IceCreamTruck_Cannon_Melted3_Sprite ?? throw new Exception());

            Part icecreamtruckmissilebay_melted0 = new Part();
            icecreamtruckmissilebay_melted0.active = true;
            icecreamtruckmissilebay_melted0.type = PType.missiles;
            icecreamtruckmissilebay_melted0.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_MissileBay_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted0", (object)icecreamtruckmissilebay_melted0, Manifest.IceCreamTruck_MissileBay_Melted0_Sprite ?? throw new Exception());
            Part icecreamtruckmissilebay_melted1 = new Part();
            icecreamtruckmissilebay_melted1.active = true;
            icecreamtruckmissilebay_melted1.type = PType.missiles;
            icecreamtruckmissilebay_melted1.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_MissileBay_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted1", (object)icecreamtruckmissilebay_melted1, Manifest.IceCreamTruck_MissileBay_Melted1_Sprite ?? throw new Exception());
            Part icecreamtruckmissilebay_melted2 = new Part();
            icecreamtruckmissilebay_melted2.active = true;
            icecreamtruckmissilebay_melted2.type = PType.missiles;
            icecreamtruckmissilebay_melted2.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_MissileBay_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted2", (object)icecreamtruckmissilebay_melted2, Manifest.IceCreamTruck_MissileBay_Melted2_Sprite ?? throw new Exception());
            Part icecreamtruckmissilebay_melted3 = new Part();
            icecreamtruckmissilebay_melted3.active = true;
            icecreamtruckmissilebay_melted3.type = PType.missiles;
            icecreamtruckmissilebay_melted3.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_MissileBay_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted3", (object)icecreamtruckmissilebay_melted3, Manifest.IceCreamTruck_MissileBay_Melted3_Sprite ?? throw new Exception());

            Part icecreamtruckcockpit_melted0 = new Part();
            icecreamtruckcockpit_melted0.active = true;
            icecreamtruckcockpit_melted0.type = PType.cockpit;
            icecreamtruckcockpit_melted0.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cockpit_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted0", (object)icecreamtruckcockpit_melted0, Manifest.IceCreamTruck_Cockpit_Melted0_Sprite ?? throw new Exception());
            Part icecreamtruckcockpit_melted1 = new Part();
            icecreamtruckcockpit_melted1.active = true;
            icecreamtruckcockpit_melted1.type = PType.cockpit;
            icecreamtruckcockpit_melted1.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cockpit_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted1", (object)icecreamtruckcockpit_melted1, Manifest.IceCreamTruck_Cockpit_Melted1_Sprite ?? throw new Exception());
            Part icecreamtruckcockpit_melted2 = new Part();
            icecreamtruckcockpit_melted2.active = true;
            icecreamtruckcockpit_melted2.type = PType.cockpit;
            icecreamtruckcockpit_melted2.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cockpit_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted2", (object)icecreamtruckcockpit_melted2, Manifest.IceCreamTruck_Cockpit_Melted2_Sprite ?? throw new Exception());
            Part icecreamtruckcockpit_melted3 = new Part();
            icecreamtruckcockpit_melted3.active = true;
            icecreamtruckcockpit_melted3.type = PType.cockpit;
            icecreamtruckcockpit_melted3.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Cockpit_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted3", (object)icecreamtruckcockpit_melted3, Manifest.IceCreamTruck_Cockpit_Melted3_Sprite ?? throw new Exception());

            Part icecreamtruckwingleft_melted0 = new Part();
            icecreamtruckwingleft_melted0.active = true;
            icecreamtruckwingleft_melted0.type = PType.wing;
            icecreamtruckwingleft_melted0.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_WingLeft_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted0", (object)icecreamtruckwingleft_melted0, Manifest.IceCreamTruck_WingLeft_Melted0_Sprite ?? throw new Exception());
            Part icecreamtruckwingleft_melted1 = new Part();
            icecreamtruckwingleft_melted1.active = true;
            icecreamtruckwingleft_melted1.type = PType.wing;
            icecreamtruckwingleft_melted1.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_WingLeft_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted1", (object)icecreamtruckwingleft_melted1, Manifest.IceCreamTruck_WingLeft_Melted1_Sprite ?? throw new Exception());
            Part icecreamtruckwingleft_melted2 = new Part();
            icecreamtruckwingleft_melted2.active = true;
            icecreamtruckwingleft_melted2.type = PType.wing;
            icecreamtruckwingleft_melted2.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_WingLeft_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted2", (object)icecreamtruckwingleft_melted2, Manifest.IceCreamTruck_WingLeft_Melted2_Sprite ?? throw new Exception());
            Part icecreamtruckwingleft_melted3 = new Part();
            icecreamtruckwingleft_melted3.active = true;
            icecreamtruckwingleft_melted3.type = PType.wing;
            icecreamtruckwingleft_melted3.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_WingLeft_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted3", (object)icecreamtruckwingleft_melted3, Manifest.IceCreamTruck_WingLeft_Melted3_Sprite ?? throw new Exception());

            Part icecreamtruckwingright_melted0 = new Part();
            icecreamtruckwingright_melted0.active = true;
            icecreamtruckwingright_melted0.type = PType.wing;
            icecreamtruckwingright_melted0.damageModifier = PDamMod.none;
            icecreamtruckwingright_melted0.flip = true;
            Manifest.IceCreamTruck_WingRight_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted0", (object)icecreamtruckwingright_melted0, Manifest.IceCreamTruck_WingLeft_Melted0_Sprite ?? throw new Exception());
            Part icecreamtruckwingright_melted1 = new Part();
            icecreamtruckwingright_melted1.active = true;
            icecreamtruckwingright_melted1.type = PType.wing;
            icecreamtruckwingright_melted1.damageModifier = PDamMod.none;
            icecreamtruckwingright_melted1.flip = true;
            Manifest.IceCreamTruck_WingRight_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted1", (object)icecreamtruckwingright_melted1, Manifest.IceCreamTruck_WingLeft_Melted1_Sprite ?? throw new Exception());
            Part icecreamtruckwingright_melted2 = new Part();
            icecreamtruckwingright_melted2.active = true;
            icecreamtruckwingright_melted2.type = PType.wing;
            icecreamtruckwingright_melted2.damageModifier = PDamMod.none;
            icecreamtruckwingright_melted2.flip = true;
            Manifest.IceCreamTruck_WingRight_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted2", (object)icecreamtruckwingright_melted2, Manifest.IceCreamTruck_WingLeft_Melted2_Sprite ?? throw new Exception());
            Part icecreamtruckwingright_melted3 = new Part();
            icecreamtruckwingright_melted3.active = true;
            icecreamtruckwingright_melted3.type = PType.wing;
            icecreamtruckwingright_melted3.damageModifier = PDamMod.none;
            icecreamtruckwingright_melted3.flip = true;
            Manifest.IceCreamTruck_WingRight_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted3", (object)icecreamtruckwingright_melted3, Manifest.IceCreamTruck_WingLeft_Melted3_Sprite ?? throw new Exception());

            Part icecreamtruckscaffolding = new Part();
            icecreamtruckscaffolding.active = true;
            icecreamtruckscaffolding.type = PType.empty;
            icecreamtruckscaffolding.damageModifier = PDamMod.none;
            Manifest.IceCreamTruck_Scaffolding = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckScaffolding", (object)icecreamtruckscaffolding, Manifest.IceCreamTruck_Scaffolding_Sprite ?? throw new Exception());

            registry.RegisterPart(Manifest.IceCreamTruck_Cannon_Melted0);
            registry.RegisterPart(Manifest.IceCreamTruck_Cannon_Melted1);
            registry.RegisterPart(Manifest.IceCreamTruck_Cannon_Melted2);
            registry.RegisterPart(Manifest.IceCreamTruck_Cannon_Melted3);
            registry.RegisterPart(Manifest.IceCreamTruck_MissileBay_Melted0);
            registry.RegisterPart(Manifest.IceCreamTruck_MissileBay_Melted1);
            registry.RegisterPart(Manifest.IceCreamTruck_MissileBay_Melted2);
            registry.RegisterPart(Manifest.IceCreamTruck_MissileBay_Melted3);
            registry.RegisterPart(Manifest.IceCreamTruck_Cockpit_Melted0);
            registry.RegisterPart(Manifest.IceCreamTruck_Cockpit_Melted1);
            registry.RegisterPart(Manifest.IceCreamTruck_Cockpit_Melted2);
            registry.RegisterPart(Manifest.IceCreamTruck_Cockpit_Melted3);
            registry.RegisterPart(Manifest.IceCreamTruck_WingLeft_Melted0);
            registry.RegisterPart(Manifest.IceCreamTruck_WingLeft_Melted1);
            registry.RegisterPart(Manifest.IceCreamTruck_WingLeft_Melted2);
            registry.RegisterPart(Manifest.IceCreamTruck_WingLeft_Melted3);
            registry.RegisterPart(Manifest.IceCreamTruck_WingRight_Melted0);
            registry.RegisterPart(Manifest.IceCreamTruck_WingRight_Melted1);
            registry.RegisterPart(Manifest.IceCreamTruck_WingRight_Melted2);
            registry.RegisterPart(Manifest.IceCreamTruck_WingRight_Melted3);
            registry.RegisterPart(Manifest.IceCreamTruck_Scaffolding);
        }
        public void LoadManifest(IShipRegistry shipRegistry)
        {
            Ship shipObjectTemplate = new Ship();
            shipObjectTemplate.baseDraw = 5;
            shipObjectTemplate.baseEnergy = 3;
            shipObjectTemplate.heatTrigger = 4;
            shipObjectTemplate.heatMin = 0;
            shipObjectTemplate.hull = 12;
            shipObjectTemplate.hullMax = 12;
            shipObjectTemplate.shieldMaxBase = 4;
            ExternalPart[] parts = new ExternalPart[5];
            parts[0] = Manifest.IceCreamTruck_WingLeft_Melted0 ?? throw new Exception();
            parts[1] = Manifest.IceCreamTruck_Cannon_Melted0 ?? throw new Exception();
            parts[2] = Manifest.IceCreamTruck_Cockpit_Melted0 ?? throw new Exception();
            parts[3] = Manifest.IceCreamTruck_MissileBay_Melted0 ?? throw new Exception();
            parts[4] = Manifest.IceCreamTruck_WingRight_Melted0 ?? throw new Exception();
            Manifest.IceCreamTruck_Ship = new ExternalShip("IceCreamTruck.Ships.IceCreamTruck", (object)shipObjectTemplate, (IEnumerable<ExternalPart>)parts, Manifest.IceCreamTruck_Chassis_Sprite);
            shipRegistry.RegisterShip(Manifest.IceCreamTruck_Ship);
        }
        public void LoadManifest(IStartershipRegistry registry)
        {
            ExternalShip iceCreamTruckShip = Manifest.IceCreamTruck_Ship;
            if (iceCreamTruckShip == null)
                throw new Exception();
            ExternalCard[] externalCardArray = new ExternalCard[0];
            //Custom Cards Here
            //externalCardArray[0] = Manifest.CustomCardsHere ?? throw new Exception();
            ExternalArtifact[] externalArtifactArray = new ExternalArtifact[1];
            //Custom Artifacts Here
            externalArtifactArray[0] = Manifest.IceCreamArtifact ?? throw new Exception();
            Manifest.IceCreamTruck_StarterShip = new ExternalStarterShip(
                "IceCreamTruck.Starterships.IceCreamTruck",
                iceCreamTruckShip, (IEnumerable<ExternalCard>)externalCardArray,
                (IEnumerable<ExternalArtifact>)externalArtifactArray,
                (IEnumerable<Type>)new Type[4]
                    {
                        //Vanilla Cards Here
                        typeof (CannonColorless),
                        typeof (CannonColorless),
                        typeof (DodgeColorless),
                        typeof (BasicShieldColorless),
                    },
                (IEnumerable<Type>)new Type[1]
                    {
                        //Vanilla Artifacts Here
                        typeof (ShieldPrep)
                    });
            Manifest.IceCreamTruck_StarterShip.AddLocalisation("IceCream Truck", "FOXLAD's dream home, it serves delicious snacks.");
            registry.RegisterStartership(Manifest.IceCreamTruck_StarterShip);
        }
    }
}