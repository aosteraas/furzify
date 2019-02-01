using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Furzify.API.Entities;

namespace Furzify.API.Extensions
{
    public static class FurzeContextExtensions
    {
        public static bool AllMigrationsApplied(this DbContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void SeedVideos(this DbContext context)
        {
            var videoList = new List<Video>()
            {
                new Video
                {
                    Title = "Wall of Death, the building process ",
                    Url =  "https://www.youtube.com/watch?v=qSjhjaN5zKI"
                },
                new Video
                {
                    Title = "Riding the WORLDS LONGEST MOTORBIKE ",
                    Url =  "https://www.youtube.com/watch?v=9YCcMyL7qTg"
                },
                new Video
                {
                    Title = "WORLDS FASTEST MOBILITY SCOOTER (The Original)",
                    Url =  "https://www.youtube.com/watch?v=i2D2fP6yBzU"
                },
                new Video
                {
                    Title = "WALL OF DEATH Teaching a man that sold his life Part 1 of 2",
                    Url =  "https://www.youtube.com/watch?v=4MZZ4k0niaE"
                },
                new Video
                {
                    Title = "WALL OF DEATH Teaching a man that sold his life Part 2 of 2",
                    Url =  "https://www.youtube.com/watch?v=4MZZ4k0niaE"
                },
                new Video
                {
                    Title = "72 Foot Scooter",
                    Url =  "https://www.youtube.com/watch?v=S54kYE227UU"
                },
                new Video
                {
                    Title = "70MPH Mobility Scooter in the Snow",
                    Url =  "https://www.youtube.com/watch?v=zy5rkw4SeP4"
                },
                new Video
                {
                    Title = "RC CARDS VS WALL OF DEATH",
                    Url =  "https://www.youtube.com/watch?v=iF1KweyWE38"
                },
                new Video
                {
                    Title = "WORLDS FASTEST PRAM/STROLLER",
                    Url =  "https://www.youtube.com/watch?v=SgZCk7tMOYc"
                },
                new Video
                {
                    Title = "WORLDS FASTEST PRAM-setting the record",
                    Url =  "https://www.youtube.com/watch?v=SgZCk7tMOYc"
                },
                new Video
                {
                    Title = "MAKING the JET BICYCLE",
                    Url =  "https://www.youtube.com/watch?v=D1EHZPjLNHk"
                },
                new Video
                {
                    Title = "The JET Bicycle - The most dangerous unsafe bike EVER",
                    Url =  "https://www.youtube.com/watch?v=bKHz7wOjb9w"
                },
                new Video
                {
                    Title = "How to build a TURBOJET Engine ",
                    Url =  "https://www.youtube.com/watch?v=Gh34A0b8MrE"
                },
                new Video
                {
                    Title = "How to build a TURBOJET ENGINE - The Maths",
                    Url =  "https://www.youtube.com/watch?v=6GywwbhqR_o"
                },
                new Video
                {
                    Title = "JET ENGINED BBQ.....The TURBAQUE",
                    Url =  "https://www.youtube.com/watch?v=QxpHJipB67g"
                },
                new Video
                {
                    Title = "Build a JET ENGINE using only a DRILL, GRINDER and duck tape (NO WELDING)",
                    Url =  "https://www.youtube.com/watch?v=InvF9e5kyjo"
                },
                new Video
                {
                    Title = "Will a JET ENGINE made from a LOO roll holder WORK?",
                    Url =  "https://www.youtube.com/watch?v=EorMrpM6q9Q"
                },
                new Video
                {
                    Title = "A NEW way to take down the xmas decorations, The UnDecor 500c",
                    Url =  "https://www.youtube.com/watch?v=Ymp3ZyHjC68"
                },
                new Video
                {
                    Title = "How to build a 60MPH MOBILITY SCOOTER #1-Frame",
                    Url =  "https://www.youtube.com/watch?v=u6arzfzwqyo"
                },
                new Video
                {
                    Title = "How to build a 60MPH MOBILITY SCOOTER #2 Axle",
                    Url =  "https://www.youtube.com/watch?v=cveCmTr-NnY"
                },
                new Video
                {
                    Title = "JetFAST Cereal-The most EXCITING CEREAL you can have.",
                    Url =  "https://www.youtube.com/watch?v=IuoI6ESP9aw"
                },
                new Video
                {
                    Title = "Larking around at Silverstone",
                    Url =  "https://www.youtube.com/watch?v=CxLWwFnZrL8"
                },
                new Video
                {
                    Title = "DIY X-MEN Making WOLVERINES CLAWS",
                    Url =  "https://www.youtube.com/watch?v=fVBCFGebqTg"
                },
                new Video
                {
                    Title = "DIY X-MEN WOLVERINE fully automatic claws",
                    Url =  "https://www.youtube.com/watch?v=sdcGek-NoFQ"
                },
                new Video
                {
                    Title = "DIY X-MEN MAGNETO walking upside down with magnetic shoes",
                    Url =  "https://www.youtube.com/watch?v=uRKHCRR9-C4"
                },
                new Video
                {
                    Title = "DIY X-MEN Making MAGNETO shoes",
                    Url =  "https://www.youtube.com/watch?v=OqLi6lrOCzs"
                },
                new Video
                {
                    Title = "DIY X-MEN Learning to walk upside down",
                    Url =  "https://www.youtube.com/watch?v=wr-7zcUuS90"
                },
                new Video
                {
                    Title = "DIY X-MEN Making PYRO's Fire control",
                    Url =  "https://www.youtube.com/watch?v=ypIGeNdJbJ4"
                },
                new Video
                {
                    Title = "DIY X-MEN PYRO shooting 12ft flames from your wrist",
                    Url =  "https://www.youtube.com/watch?v=D5_ogU4Jzt4"
                },
                new Video
                {
                    Title = "Fart@France-The Result",
                    Url =  "https://www.youtube.com/watch?v=7Ydv9Ef-99I"
                },
                new Video
                {
                    Title = "HydroForming with a Pressure Washer-PULSE JET",
                    Url =  "https://www.youtube.com/watch?v=bCsg5pQimWI"
                },
                new Video
                {
                    Title = "FIREWORK SAFETY SUIT-Stand INSIDE a fireworks display",
                    Url =  "https://www.youtube.com/watch?v=eA46WFX7jWA"
                },
                new Video
                {
                    Title = "Making the ICE bike",
                    Url =  "https://www.youtube.com/watch?v=pSlBk1uWH88"
                },
                new Video
                {
                    Title = "Squeezing a 600cc engine in to a Tuk Tuk (Far Cry 4)",
                    Url =  "https://www.youtube.com/watch?v=0d5ntPLnn78"
                },
                new Video
                {
                    Title = "The ULTIMATE Tuk Tuk (rickshaw) Unleashed the TUK600 (Far Cry 4)",
                    Url =  "https://www.youtube.com/watch?v=7y93MYaTx6M"
                },
                new Video
                {
                    Title = "Filming in the stratosphere with a HTC mobile phone + fireworks at 20,000ft",
                    Url =  "https://www.youtube.com/watch?v=YvzMpet3648"
                },
                new Video
                {
                    Title = "Karaoke Shower",
                    Url =  "https://www.youtube.com/watch?v=Y6wOcXQ1ALQ"
                },
                new Video
                {
                    Title = "Making a Jet Powered Go-Kart Part 1 - Chassis",
                    Url =  "https://www.youtube.com/watch?v=U76uh50K_JE"
                },
                new Video
                {
                    Title = "Making a Jet Go-Kart Part 2 - Controls/Fuel",
                    Url =  "https://www.youtube.com/watch?v=ckar-ukwYH8"
                },
                new Video
                {
                    Title = "Jet-kart-The most MENTAL kart EVER",
                    Url =  "https://www.youtube.com/watch?v=zsXWspo5hrc"
                },
                new Video
                {
                    Title = "1 MILLION SUBSCRIBERS FIREWORK launch Preparation",
                    Url =  "https://www.youtube.com/watch?v=_fvwJD628fg"
                },
                new Video
                {
                    Title = "Setting off 300 Rockets ALL AT ONCE",
                    Url =  "https://www.youtube.com/watch?v=yQf5cGPcP48"
                },
                new Video
                {
                    Title = "The Toasting Knife",
                    Url =  "https://www.youtube.com/watch?v=kcjGRXTpHGI"
                },
                new Video
                {
                    Title = "Making the Toaster Knife",
                    Url =  "https://www.youtube.com/watch?v=OZpBMfA9lZs"
                },
                new Video
                {
                    Title = "Building a MotorHorse???",
                    Url =  "https://www.youtube.com/watch?v=1mwdc78YaUE"
                },
                new Video
                {
                    Title = "Making the High Voltage Ejector Bed",
                    Url =  "https://www.youtube.com/watch?v=tg_STsy86Fw"
                },
                new Video
                {
                    Title = "The High Voltage Ejector Bed",
                    Url =  "https://www.youtube.com/watch?v=EVzn1pl4nlo"
                },
                new Video
                {
                    Title = "Apocalyptic BUNKER project part 1- The Plan",
                    Url =  "https://www.youtube.com/watch?v=8UKNajCgpEs"
                },
                new Video
                {
                    Title = "Apocalyptic BUNKER project part 2 - The Dig",
                    Url =  "https://www.youtube.com/watch?v=z8yiuJ9yFic"
                },
                new Video
                {
                    Title = "Apocalyptic BUNKER project part 3 - Making the Bunker",
                    Url =  "https://www.youtube.com/watch?v=p1t7r3SKT2o"
                },
                new Video
                {
                    Title = "Making a Real Assassin's Creed Rope Launcher Part 2 - Winching me UP",
                    Url =  "https://www.youtube.com/watch?v=arbNxONg88c"
                },
                new Video
                {
                    Title = "REAL Assassin's Creed HIDDEN BLADE & ROPE LAUNCHER",
                    Url =  "https://www.youtube.com/watch?v=ESFewdU0JcA"
                },
                new Video
                {
                    Title = "Apocalyptic BUNKER project part 4 - Concrete",
                    Url =  "https://www.youtube.com/watch?v=pR493Pee6Xo"
                },
                new Video
                {
                    Title = "Backyard UNDERGROUND Apocalyptic BUNKER",
                    Url =  "https://www.youtube.com/watch?v=KO25JYAaJC0"
                },
                new Video
                {
                    Title = "Making the hidden blade from Assassins Creed",
                    Url =  "https://www.youtube.com/watch?v=VmvcirebyY4"
                },
                new Video
                {
                    Title = "Underground BUNKER project - 360 degree virtual reality EXPERIENCE",
                    Url =  "https://www.youtube.com/watch?v=QnYncJdEh64"
                },
                new Video
                {
                    Title = "Making a Motorised Drift Trike",
                    Url =  "https://www.youtube.com/watch?v=A_w5esx445w"
                },
                new Video
                {
                    Title = "Motorised Drift Trike = FUN",
                    Url =  "https://www.youtube.com/watch?v=dGOuu7K2BH0"
                },
                new Video
                {
                    Title = "Making a Centrifugal TURKEY Cooking Machine",
                    Url =  "https://www.youtube.com/watch?v=JZM1fQitsx8"
                },
                new Video
                {
                    Title = "Xmas Spinner Turkey Cooking Machine (With Jamie Oliver)",
                    Url =  "https://www.youtube.com/watch?v=2ywTcBSXAiQ"
                },
                new Video
                {
                    Title = "Colin Furze 2015",
                    Url =  "https://www.youtube.com/watch?v=N_DQ9YLnsX4"
                },
                new Video
                {
                    Title = "2 Million Subscribers Firework Celebration Preparation",
                    Url =  "https://www.youtube.com/watch?v=nWyt3Uz8lwU"
                },
                new Video
                {
                    Title = "Giant Rocket Powered Firework Wheel",
                    Url =  "https://www.youtube.com/watch?v=tY5Wzjk0-Xs"
                },
                new Video
                {
                    Title = "Pulse Jet Drift Trike",
                    Url =  "https://www.youtube.com/watch?v=DMDLaQD8yAU"
                },
                new Video
                {
                    Title = "RC Bin/trash can Pranking on the Streets",
                    Url =  "https://www.youtube.com/watch?v=DMG-hMJhySk"
                },
                new Video
                {
                    Title = "Making a Firework Rocket Launcher",
                    Url =  "https://www.youtube.com/watch?v=IBus-OpyX5c"
                },
                new Video
                {
                    Title = "Firework Rocket Launcher",
                    Url =  "https://www.youtube.com/watch?v=JcFh177fqu0"
                },
                new Video
                {
                    Title = "Making a THERMITE LAUNCHER Part 1-Thermite shells",
                    Url =  "https://www.youtube.com/watch?v=9XAnx5x8E-8"
                },
                new Video
                {
                    Title = "Making a Thermite Launcher Part 2-Making the Launcher",
                    Url =  "https://www.youtube.com/watch?v=uDm3is3PDc0"
                },
                new Video
                {
                    Title = "The Thermite Launcher",
                    Url =  "https://www.youtube.com/watch?v=JEoqrjFX1yI"
                },
                new Video
                {
                    Title = "Lets make a Flying Machine-Thrust Test",
                    Url =  "https://www.youtube.com/watch?v=iFtmrUscNqA"
                },
                new Video
                {
                    Title = "Making a Home made Hoverbike",
                    Url =  "https://www.youtube.com/watch?v=1ToBgypNwL4"
                },
                new Video
                {
                    Title = "Homemade Hoverbike",
                    Url =  "https://www.youtube.com/watch?v=soxxPyaAT1k"
                },
                new Video
                {
                    Title = "Making a Smoking/Strobing Bass",
                    Url =  "https://www.youtube.com/watch?v=pSbI5_75BlM"
                },
                new Video
                {
                    Title = "Making a Flamethrower Guitar",
                    Url =  "https://www.youtube.com/watch?v=2seXZcx-0W8"
                },
                new Video
                {
                    Title = "3 Million Subscriber Firework Preparation",
                    Url =  "https://www.youtube.com/watch?v=zWGhgZypKQg"
                },
                new Video
                {
                    Title = "5000 shot Firework Deathstar",
                    Url =  "https://www.youtube.com/watch?v=gEUBLIFMgnY"
                },
                new Video
                {
                    Title = "DIY X-MEN Making Ice Man palm mounted Liquid Nitrogen Freeze Blaster",
                    Url =  "https://www.youtube.com/watch?v=yrvwOEwawsA"
                },
                new Video
                {
                    Title = "DIY X-Men Ice Man- Palm Mounted Liquid Nitrogen Blasters",
                    Url =  "https://www.youtube.com/watch?v=Hs0lpWN_SoI"
                },
                new Video
                {
                    Title = "The Ultimate Door Bell",
                    Url =  "https://www.youtube.com/watch?v=rrLtoC8nNeA"
                },
                new Video
                {
                    Title = "Making a HUGE 360 Swing #1 Chassis",
                    Url =  "https://www.youtube.com/watch?v=N0wfkpBImKw"
                },
                new Video
                {
                    Title = "Making a Huge 360 Swing #2 Swing Arm",
                    Url =  "https://www.youtube.com/watch?v=9qMXOyiRymY"
                },
                new Video
                {
                    Title = "HUGE Homemade 360 Swing",
                    Url =  "https://www.youtube.com/watch?v=J9uh-CyBMCs"
                },
                new Video
                {
                    Title = "360 Swing + Paramotor",
                    Url =  "https://www.youtube.com/watch?v=sjTuJpgyaW8"
                },
                new Video
                {
                    Title = "Weaponised arm Gauntlet Deus Ex: Mankind Divided Style Making of #1 chassis and rocket launcher",
                    Url =  "https://www.youtube.com/watch?v=Nw6FLKvcuqg"
                },
                new Video
                {
                    Title = "Ballistic Knife/Taser Weaponised arm Gauntlet Deus Ex: Mankind Divided Style Making of Part 2",
                    Url =  "https://www.youtube.com/watch?v=jlHH0xvFM3o"
                },
                new Video
                {
                    Title = "REAL Weaponised Gauntlet Deus Ex Style",
                    Url =  "https://www.youtube.com/watch?v=aR4TsEjpQyM"
                },
                new Video
                {
                    Title = "Behind the Scenes, what goes into to making a video and blowing up drones in the bunker.",
                    Url =  "https://www.youtube.com/watch?v=BiYkAlTT1MU"
                },
                new Video
                {
                    Title = "How to build a really SOLID shed",
                    Url =  "https://www.youtube.com/watch?v=LP67MAoihZk"
                },
                new Video
                {
                    Title = "Stomp O Matic - Waste Squeezer stompy thingy",
                    Url =  "https://www.youtube.com/watch?v=ysr9yOY53bk"
                },
                new Video
                {
                    Title = "Making a Motorised Go Cart with NO WELDER and simple tools #1 - Chassis/Engine",
                    Url =  "https://www.youtube.com/watch?v=vuRV-uXGy1w"
                },
                new Video
                {
                    Title = "Making a Motorised Go Cart with NO WELDER and simple tools #2 Finish/Test",
                    Url =  "https://www.youtube.com/watch?v=nnPQm4W7vM0"
                },
                new Video
                {
                    Title = "#Made for you Play Button",
                    Url =  "https://www.youtube.com/watch?v=Ws1W7jOe53w"
                },
                new Video
                {
                    Title = "What i Filmed Before Youtube 10 year anniversary Special",
                    Url =  "https://www.youtube.com/watch?v=NuqkM4oOiEc"
                },
                new Video
                {
                    Title = "What 10 years of FURZE builds looks like",
                    Url =  "https://www.youtube.com/watch?v=VSHGNs0PA_g"
                },
                new Video
                {
                    Title = "Building a HUGE Star Wars AT-AT",
                    Url =  "https://www.youtube.com/watch?v=t8IYwnXgAj4"
                },
                new Video
                {
                    Title = "GIANT Star Wars AT-ACT",
                    Url =  "https://www.youtube.com/watch?v=sE1mr8iCvA8"
                },
                new Video
                {
                    Title = "Making a HUGE Fire Tornado #1 Base",
                    Url =  "https://www.youtube.com/watch?v=FgNMJB5UTvI"
                },
                new Video
                {
                    Title = "Making a HUGE Fire Tornado #2 Cage",
                    Url =  "https://www.youtube.com/watch?v=tWlCj_zhqSs"
                },
                new Video
                {
                    Title = "20ft Fire Tornado Firework Launcher",
                    Url =  "https://www.youtube.com/watch?v=5-e2tAUo89o"
                },
                new Video
                {
                    Title = "Fire Tornado Firework Explosion SLOW MOTION",
                    Url =  "https://www.youtube.com/watch?v=RlJVazOHaZc"
                },
                new Video
                {
                    Title = "Colin Furze Top Gear Project #1 BIG ENGINE Small Bumper Car",
                    Url =  "https://www.youtube.com/watch?v=tEQopnaHipo"
                },
                new Video
                {
                    Title = "Squeezing 600cc 100BHP Engine in a Bumper car #2 Colin Furze Top Gear Project",
                    Url =  "https://www.youtube.com/watch?v=oKANFyeGXxc"
                },
                new Video
                {
                    Title = "World's Fastest Bumper Car - 600cc 100bhp But how FAST?",
                    Url =  "https://www.youtube.com/watch?v=fGr0oifJMEI"
                },
                new Video
                {
                    Title = "100mph Bumper Car Tech Tour/Testing Footage",
                    Url =  "https://www.youtube.com/watch?v=GNZkAe9tOVw"
                },
                new Video
                {
                    Title = "Hoverbike WON the Award so i made this!",
                    Url =  "https://www.youtube.com/watch?v=92mIJG-89Bk"
                },
                new Video
                {
                    Title = "Games Console Microwave",
                    Url =  "https://www.youtube.com/watch?v=_0HT-K6Y3O8"
                },
                new Video
                {
                    Title = "Underground Beach Hut Build",
                    Url =  "https://www.youtube.com/watch?v=yox9CKYh7EU"
                },
                new Video
                {
                    Title = "This Beach Hut has a HIDDEN SECRET",
                    Url =  "https://www.youtube.com/watch?v=AojTrc_UMaM"
                },
                new Video
                {
                    Title = "AK47 door bell system.",
                    Url =  "https://www.youtube.com/watch?v=LuY1gDC-l50"
                },
                new Video
                {
                    Title = "Crazy loud Exhaust Mod - Scrimp my Ride",
                    Url =  "https://www.youtube.com/watch?v=ai6Xo0uYcWw"
                },
                new Video
                {
                    Title = "Exterior Car Sound System - Scrimp my Ride",
                    Url =  "https://www.youtube.com/watch?v=V8fomrZUxv4"
                },
                new Video
                {
                    Title = "Making a 1000 ROCKET launch Bike",
                    Url =  "https://www.youtube.com/watch?v=ultu7onL2NU"
                },
                new Video
                {
                    Title = "1000 ROCKETS Launched off Bicycle",
                    Url =  "https://www.youtube.com/watch?v=2esw8U2NENo"
                },
                new Video
                {
                    Title = "How to Make an Auto Nerf Trigger System \"Colin Furze Book Project #1\"",
                    Url =  "https://www.youtube.com/watch?v=4pb9OxdDGfk"
                },
                new Video
                {
                    Title = "I Dropped my Book from Space",
                    Url =  "https://www.youtube.com/watch?v=NTYh6sIHKvE"
                },
                new Video
                {
                    Title = "Sealing a car and Filling with WATER but still DRIVES",
                    Url =  "https://www.youtube.com/watch?v=p3TPPGb1X8A"
                },
                new Video
                {
                    Title = "BBQ Grass 2stroke Bubbles HotTub Car Final Touches",
                    Url =  "https://www.youtube.com/watch?v=KHshdXDxR3c"
                },
                new Video
                {
                    Title = "Spa Car BMW Hot Tub",
                    Url =  "https://www.youtube.com/watch?v=Koxzz7LDmEE"
                },
                new Video
                {
                    Title = "BMW Hot Tub First Tests and Issues",
                    Url =  "https://www.youtube.com/watch?v=HqHQFm5L6Zc"
                },
                new Video
                {
                    Title = "Making an Inset Bench Metal Folder/Brake",
                    Url =  "https://www.youtube.com/watch?v=Ggy1DHwAh_0"
                },
                new Video
                {
                    Title = "The Washing Machine that would not Die",
                    Url =  "https://www.youtube.com/watch?v=VsRot0p7ObY"
                },
                new Video
                {
                    Title = "I Built a FULL SIZE Tie Fighter/Silencer",
                    Url =  "https://www.youtube.com/watch?v=sTvY9Llqtms"
                },
                new Video
                {
                    Title = "Building a Huge Tie Fighter",
                    Url =  "https://www.youtube.com/watch?v=kkq3lAW875o"
                },
                new Video
                {
                    Title = "We Built a Snowman on the car and went for drive haha.",
                    Url =  "https://www.youtube.com/watch?v=Rf9VVkpGTXs"
                },
                new Video
                {
                    Title = "Furze's Christmas Special",
                    Url =  "https://www.youtube.com/watch?v=H3nWHsB4sRA"
                },
                new Video
                {
                    Title = "Making a Handheld Air Cannon Steampunk/Powerfull",
                    Url =  "https://www.youtube.com/watch?v=9i3GtPIS0-4"
                },
                new Video
                {
                    Title = "Handheld Potato Launcher also does Pineapple/cake n yogurt haha",
                    Url =  "https://www.youtube.com/watch?v=MePIx82V1ks"
                },
                new Video
                {
                    Title = "Voice Activated Bed Shaker - How To",
                    Url =  "https://www.youtube.com/watch?v=22rysDq8PE0"
                },
                new Video
                {
                    Title = "Alexia Activated Flamethrower",
                    Url =  "https://www.youtube.com/watch?v=dVQ6rwaZ648"
                },
                new Video
                {
                    Title = "Extreme Bed Shaker - Voice Activated Wake Up Machine",
                    Url =  "https://www.youtube.com/watch?v=5KwMvmyRsFI"
                },
                new Video
                {
                    Title = "Making the Hulkbuster Part 1-Legs, Huge Hydraulic Legs",
                    Url =  "https://www.youtube.com/watch?v=kSuaykdvl4I"
                },
                new Video
                {
                    Title = "Making the Hulkbuster Part 2 - Body Arms and hips",
                    Url =  "https://www.youtube.com/watch?v=FO6My1joJVc"
                },
                new Video
                {
                    Title = "Homemade Hydraulic Hulkbuster",
                    Url =  "https://www.youtube.com/watch?v=AshvBTw5Z84"
                },
                new Video
                {
                    Title = "Hulkbuster Extra - Making Power fist +",
                    Url =  "https://www.youtube.com/watch?v=K0EodNv8pQU"
                },
                new Video
                {
                    Title = "Walking Stick Tazer",
                    Url =  "https://www.youtube.com/watch?v=I9tcceouEqY"
                },
                new Video
                {
                    Title = "THE BICYCLE OF SPRINGS",
                    Url =  "https://www.youtube.com/watch?v=N39uwTykTQk"
                },
                new Video
                {
                    Title = "Jet Powered Kids Scooter",
                    Url =  "https://www.youtube.com/watch?v=-rHOqwmqZIQ"
                },
                new Video
                {
                    Title = "Making a Chainsaw Table Lamp",
                    Url =  "https://www.youtube.com/watch?v=yeBQsV2sH7M"
                },
                new Video
                {
                    Title = "CHAINSAW POWERED LAMP",
                    Url =  "https://www.youtube.com/watch?v=ia22wxdDzo0"
                },
                new Video
                {
                    Title = "Motorised Retractable Roof Project (super villain style)",
                    Url =  "https://www.youtube.com/watch?v=LGozfCxnmTc"
                },
                new Video
                {
                    Title = "Setting up/Testing the 700 Rocket Mushroom Rig",
                    Url =  "https://www.youtube.com/watch?v=intFcQuXcyA"
                },
                new Video
                {
                    Title = "F work Rocket Mushroom (run \"for your life\")",
                    Url =  "https://www.youtube.com/watch?v=fzMi6yf1Roc"
                },
                new Video
                {
                    Title = "Rims-Lift-and Bass Scooter Pimp #1",
                    Url =  "https://www.youtube.com/watch?v=4j7BplVWpUo"
                },
                new Video
                {
                    Title = "Hydraulic Crane Seat-Scooter Pimp #2",
                    Url =  "https://www.youtube.com/watch?v=yVAK-S_1vhU"
                },
                new Video
                {
                    Title = "Underseat Flamethrowers-Scooter Pimp #3",
                    Url =  "https://www.youtube.com/watch?v=NBq7fh7uvW8"
                },
                new Video
                {
                    Title = "1000RPM SPINNING BELT OF KNIVES",
                    Url =  "https://www.youtube.com/watch?v=vWGquxvqI_Y"
                },
                new Video
                {
                    Title = "TurboJet Scooter build #1-Jet/Chassis",
                    Url =  "https://www.youtube.com/watch?v=4MUGIr85zfs"
                },
                new Video
                {
                    Title = "TurboJet Scooter Build #2-Oil/Fuel/Test Fire",
                    Url =  "https://www.youtube.com/watch?v=bcd3vg-5hDA"
                },
                new Video
                {
                    Title = "TurboJet Powered Scooter-IT'S ALIVE",
                    Url =  "https://www.youtube.com/watch?v=83jH0sVCM9Q"
                },
                new Video
                {
                    Title = "Gas Heated Umbrella - Because British Weather",
                    Url =  "https://www.youtube.com/watch?v=PWTPFm6eZzs"
                },
                new Video
                {
                    Title = "Mr Beans RC Armchair",
                    Url =  "https://www.youtube.com/watch?v=9ro0_lJSNLw"
                },
                new Video
                {
                    Title = "Most INTENSE CRAZY FIREWORKS you have ever seen",
                    Url =  "https://www.youtube.com/watch?v=EqyTfHqdUyI"
                },
                new Video
                {
                    Title = "Making a Shredder for my Letterbox (No more junk mail)",
                    Url =  "https://www.youtube.com/watch?v=ku9W-pqDLdw"
                },
                new Video
                {
                    Title = "Letterbox SHREDDER shreds EVERYTHING",
                    Url =  "https://www.youtube.com/watch?v=zubmkHMRP3U"
                },
                new Video
                {
                    Title = "Burning the Wall Of Death",
                    Url =  "https://www.youtube.com/watch?v=GKvMhYCJA-c"
                },
                new Video
                {
                    Title = "sqweezing 26ft tree in 18ft House",
                    Url =  "https://www.youtube.com/watch?v=zIJgDW09Lns"
                },
                new Video
                {
                    Title = "I made a Catapult Toaster, CATCH",
                    Url =  "https://www.youtube.com/watch?v=Rslps0Yxbdw"
                },
                new Video
                {
                    Title = "Making a Staircase Treadmill",
                    Url =  "https://www.youtube.com/watch?v=rv1qZP2P6Yc"
                },
                new Video
                {
                    Title = "STAIRCASE TREADMILL The ultimate exercise machine",
                    Url = "https://www.youtube.com/watch?v=Ya1iDTix8Js"
                }
            };
        }

        public static void SeedBands(this DbContext context)
        {

        }
    }
}