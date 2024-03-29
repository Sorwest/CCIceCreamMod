﻿using CobaltCoreModding.Definitions;
using CobaltCoreModding.Definitions.ExternalItems;
using CobaltCoreModding.Definitions.ModContactPoints;
using CobaltCoreModding.Definitions.ModManifests;
using IceCreamTruck.Artifacts;
using Microsoft.Extensions.Logging;
namespace IceCreamTruck
{
    public partial class Manifest :
    ISpriteManifest,
    IManifest,
    //IDeckManifest,
    //ICharacterManifest,
    //IAnimationManifest,
    //IStatusManifest,
    IArtifactManifest,
    IShipPartManifest,
    IShipManifest,
    IStartershipManifest
    {
        public IEnumerable<DependencyEntry> Dependencies => Array.Empty<DependencyEntry>();
        public ILogger? Logger { get; set; }
        private static System.Drawing.Color IceCreamTruck_Primary_Color = System.Drawing.Color.FromArgb(255, 143, 171);
        public static ExternalArtifact? IceCreamArtifact { get; private set; }
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
        public DirectoryInfo? ModRootFolder { get; set; }
        public string Name { get; init; } = "Sorwest.IceCreamTruck";
        public DirectoryInfo? GameRootFolder { get; set; }
        void ISpriteManifest.LoadManifest(ISpriteRegistry artRegistry)
        {
            if (ModRootFolder == null)
                throw new Exception("Root Folder not set");
            //ship parts
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted0_Sprite.png"));
                IceCreamTruck_Cannon_Melted0_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted0_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cannon_Melted0_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted1_Sprite.png"));
                IceCreamTruck_Cannon_Melted1_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted1_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cannon_Melted1_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted2_Sprite.png"));
                IceCreamTruck_Cannon_Melted2_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted2_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cannon_Melted2_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cannon_Melted3_Sprite.png"));
                IceCreamTruck_Cannon_Melted3_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cannon_Melted3_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cannon_Melted3_Sprite);
            }

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted0_Sprite.png"));
                IceCreamTruck_MissileBay_Melted0_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted0_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_MissileBay_Melted0_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted1_Sprite.png"));
                IceCreamTruck_MissileBay_Melted1_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted1_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_MissileBay_Melted1_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted2_Sprite.png"));
                IceCreamTruck_MissileBay_Melted2_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted2_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_MissileBay_Melted2_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_MissileBay_Melted3_Sprite.png"));
                IceCreamTruck_MissileBay_Melted3_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_MissileBay_Melted3_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_MissileBay_Melted3_Sprite);
            }

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted0_Sprite.png"));
                IceCreamTruck_Cockpit_Melted0_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted0_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cockpit_Melted0_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted1_Sprite.png"));
                IceCreamTruck_Cockpit_Melted1_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted1_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cockpit_Melted1_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted2_Sprite.png"));
                IceCreamTruck_Cockpit_Melted2_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted2_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cockpit_Melted2_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Cockpit_Melted3_Sprite.png"));
                IceCreamTruck_Cockpit_Melted3_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Cockpit_Melted3_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Cockpit_Melted3_Sprite);
            }

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted0_Sprite.png"));
                IceCreamTruck_WingLeft_Melted0_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted0_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_WingLeft_Melted0_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted1_Sprite.png"));
                IceCreamTruck_WingLeft_Melted1_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted1_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_WingLeft_Melted1_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted2_Sprite.png"));
                IceCreamTruck_WingLeft_Melted2_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted2_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_WingLeft_Melted2_Sprite);
            }
            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_WingLeft_Melted3_Sprite.png"));
                IceCreamTruck_WingLeft_Melted3_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_WingLeft_Melted3_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_WingLeft_Melted3_Sprite);
            }

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Scaffolding_Sprite.png"));
                IceCreamTruck_Scaffolding_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Scaffolding_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Scaffolding_Sprite);
            }

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_Chassis_Sprite.png"));
                IceCreamTruck_Chassis_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamTruck_Chassis_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamTruck_Chassis_Sprite);
            }

            //artifacts

            {
                var path = Path.Combine(ModRootFolder.FullName, "Sprites", Path.GetFileName("IceCreamTruck_IceCreamArtifact_Sprite.png"));
                IceCreamArtifact_Sprite = new ExternalSprite("IceCreamTruck.sprites.IceCreamArtifact_Sprite", new FileInfo(path));
                artRegistry.RegisterArt(IceCreamArtifact_Sprite);
            }
        }
        public void LoadManifest(IArtifactRegistry registry)
        {
            {
                IceCreamArtifact = new ExternalArtifact("IceCreamTruck.Artifacts.IceCreamArtifact",
                    typeof(IceCreamArtifact),
                    IceCreamArtifact_Sprite ?? throw new Exception("missing icecream sprite"));

                IceCreamArtifact.AddLocalisation("ICE CREAM",
                    "Unused <c=energy>ENERGY</c> is regained at the beginning of the next turn.");

                registry.RegisterArtifact(IceCreamArtifact);
            }
        }
        public void LoadManifest(IShipPartRegistry registry)
        {
            IceCreamTruck_Cannon_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted0",
                new Part()
                {
                    active = true,
                    type = PType.cannon
                },
                IceCreamTruck_Cannon_Melted0_Sprite ?? throw new Exception());
            IceCreamTruck_Cannon_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted1",
                new Part()
                {
                    active = true,
                    type = PType.cannon
                },
                IceCreamTruck_Cannon_Melted1_Sprite ?? throw new Exception());
            IceCreamTruck_Cannon_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted2",
                new Part()
                {
                    active = true,
                    type = PType.cannon
                },
                IceCreamTruck_Cannon_Melted2_Sprite ?? throw new Exception());
            IceCreamTruck_Cannon_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCannon_Melted3",
                new Part()
                {
                    active = true,
                    type = PType.cannon
                },
                IceCreamTruck_Cannon_Melted3_Sprite ?? throw new Exception());

            IceCreamTruck_MissileBay_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted0",
                new Part()
                {
                    active = true,
                    type = PType.missiles
                },
                IceCreamTruck_MissileBay_Melted0_Sprite ?? throw new Exception());
            IceCreamTruck_MissileBay_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted1",
                new Part()
                {
                    active = true,
                    type = PType.missiles
                },
                IceCreamTruck_MissileBay_Melted1_Sprite ?? throw new Exception());
            IceCreamTruck_MissileBay_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted2",
                new Part()
                {
                    active = true,
                    type = PType.missiles
                },
                IceCreamTruck_MissileBay_Melted2_Sprite ?? throw new Exception());
            IceCreamTruck_MissileBay_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckMissileBay_Melted3",
                new Part()
                {
                    active = true,
                    type = PType.missiles
                },
                IceCreamTruck_MissileBay_Melted3_Sprite ?? throw new Exception());

            IceCreamTruck_Cockpit_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted0",
                new Part()
                {
                    active = true,
                    type = PType.cockpit
                },
                IceCreamTruck_Cockpit_Melted0_Sprite ?? throw new Exception());
            IceCreamTruck_Cockpit_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted1",
                new Part()
                {
                    active = true,
                    type = PType.cockpit
                },
                IceCreamTruck_Cockpit_Melted1_Sprite ?? throw new Exception());
            IceCreamTruck_Cockpit_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted2",
                new Part()
                {
                    active = true,
                    type = PType.cockpit
                },
                IceCreamTruck_Cockpit_Melted2_Sprite ?? throw new Exception());
            IceCreamTruck_Cockpit_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckCockpit_Melted3",
                new Part()
                {
                    active = true,
                    type = PType.cockpit
                },
                IceCreamTruck_Cockpit_Melted3_Sprite ?? throw new Exception());

            IceCreamTruck_WingLeft_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted0",
                new Part()
                {
                    active = true,
                    type = PType.wing
                },
                IceCreamTruck_WingLeft_Melted0_Sprite ?? throw new Exception());
            IceCreamTruck_WingLeft_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted1",
                new Part()
                {
                    active = true,
                    type = PType.wing
                },
                IceCreamTruck_WingLeft_Melted1_Sprite ?? throw new Exception());
            IceCreamTruck_WingLeft_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted2",
                new Part()
                {
                    active = true,
                    type = PType.wing
                },
                IceCreamTruck_WingLeft_Melted2_Sprite ?? throw new Exception());
            IceCreamTruck_WingLeft_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingLeft_Melted3",
                new Part()
                {
                    active = true,
                    type = PType.wing
                },
                IceCreamTruck_WingLeft_Melted3_Sprite ?? throw new Exception());

            IceCreamTruck_WingRight_Melted0 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted0",
                new Part()
                {
                    active = true,
                    type = PType.wing,
                    flip = true
                },
                IceCreamTruck_WingLeft_Melted0_Sprite ?? throw new Exception());
            IceCreamTruck_WingRight_Melted1 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted1",
                new Part()
                {
                    active = true,
                    type = PType.wing,
                    flip = true
                },
                IceCreamTruck_WingLeft_Melted1_Sprite ?? throw new Exception());
            IceCreamTruck_WingRight_Melted2 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted2",
                new Part()
                {
                    active = true,
                    type = PType.wing,
                    flip = true
                },
                IceCreamTruck_WingLeft_Melted2_Sprite ?? throw new Exception());
            IceCreamTruck_WingRight_Melted3 = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckWingRight_Melted3",
                new Part()
                {
                    active = true,
                    type = PType.wing,
                    flip = true
                },
                IceCreamTruck_WingLeft_Melted3_Sprite ?? throw new Exception());

            IceCreamTruck_Scaffolding = new ExternalPart("IceCreamTruck.Parts.IceCreamTruckScaffolding",
                new Part()
                {
                    active = true,
                    type = PType.empty,
                },
                IceCreamTruck_Scaffolding_Sprite ?? throw new Exception());

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
            IceCreamTruck_Ship = new ExternalShip("IceCreamTruck.Ships.IceCreamTruck",
                new Ship()
                {
                    baseDraw = 5,
                    baseEnergy = 3,
                    heatTrigger = 3,
                    heatMin = 0,
                    hull = 12,
                    hullMax = 12,
                    shieldMaxBase = 4,
                },
                new ExternalPart[]
                {
                IceCreamTruck_WingLeft_Melted0 ?? throw new Exception(),
                IceCreamTruck_Cannon_Melted0 ?? throw new Exception(),
                IceCreamTruck_Cockpit_Melted0 ?? throw new Exception(),
                IceCreamTruck_MissileBay_Melted0 ?? throw new Exception(),
                IceCreamTruck_WingRight_Melted0 ?? throw new Exception(),
                },
                IceCreamTruck_Chassis_Sprite);
            shipRegistry.RegisterShip(IceCreamTruck_Ship);
        }
        public void LoadManifest(IStartershipRegistry registry)
        {
            IceCreamTruck_StarterShip = new ExternalStarterShip("IceCreamTruck.Starterships.IceCreamTruck",
                IceCreamTruck_Ship ?? throw new Exception(),
                new ExternalCard[] { },
                new ExternalArtifact[] { IceCreamArtifact ?? throw new Exception() },
                new Type[] { typeof(CannonColorless), typeof(CannonColorless), typeof(BasicShieldColorless) },
                new Type[] { typeof(ShieldPrep)
                });
            IceCreamTruck_StarterShip.AddLocalisation("IceCream Truck", "Scoop and eat, it's an ice cream ship!");
            registry.RegisterStartership(Manifest.IceCreamTruck_StarterShip);
        }
    }
}