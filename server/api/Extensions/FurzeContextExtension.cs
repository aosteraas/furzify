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

        public static void SeedVideos(this FurzeContext context)
        {
            if (!context.Videos.Any())
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
                context.Videos.AddRange(videoList);
                context.SaveChanges();
            }

        }

        public static void SeedBands(this FurzeContext context)
        {
            if (!context.Bands.Any())
            {
                var bandList = new List<Band>()
                {
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Mrs World Peace",
                                Spotify = "https://open.spotify.com/track/6u3sWa7d3YDOys6z0AqA7F",
                                YouTubeMusic = "https://music.youtube.com/watch?v=ZjattYNoM_Q",
                                YouTube = "https://www.youtube.com/watch?v=ZjattYNoM_Q",
                                AppleMusic = "https://itunes.apple.com/au/album/mrs-world-peace/1441026306"
                            }
                        },
                        Name = "Machine Gun Men",
                        Facebook = "https://www.facebook.com/MachineGunMen/",
                        Spotify = "https://open.spotify.com/artist/4nYqlHPagixAkYenxTEUm9",
                        Bandcamp =  "https://machinegunmen.bandcamp.com/",
                        ReverbNation =  "https://www.reverbnation.com/machinegunmen"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Back on Track",
                                Spotify = "https://open.spotify.com/track/4JyV4225znU2FWlEUdbAVJ",
                                YouTubeMusic = "https://music.youtube.com/watch?v=Y5YX3Yg5aOc",
                                AppleMusic = "https://itunes.apple.com/au/album/back-on-track/878995561"
                            }
                        },
                        Name = "10 to Go",
                        Instagram = "https://instagram.com/10_to_go/",
                        Bandcamp =  "https://10togo.bandcamp.com/",
                        Facebook = "https://www.facebook.com/10TOGOBAND/",
                        SoundCloud = "https://soundcloud.com/10-to-go",
                        YouTube = "https://www.youtube.com/user/10TOGOBAND",
                        ReverbNation =  "https://www.reverbnation.com/10togoband",
                        Spotify = "https://open.spotify.com/artist/1DLBD6Rhp3kKjzamA9lULf"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Sleep Softly",
                                Spotify = "https://open.spotify.com/track/6GhK8EIn9u13p7CxTgRohm",
                                YouTubeMusic = "https://music.youtube.com/watch?v=-0z3q1U1ZEA",
                                YouTube = "https://www.youtube.com/watch?v=-0z3q1U1ZEA",
                                AppleMusic = "https://itunes.apple.com/au/album/sleep-softly/1419799861"
                            },
                            new Song
                            {
                                Name = "The Ego and the Universe",
                                YouTubeMusic = "https://music.youtube.com/watch?v=4vn5S0DaCss",
                                YouTube = "https://youtube.com/watch?v=4vn5S0DaCss",
                                Spotify = "https://open.spotify.com/track/7lZPoN4alY9LXiKglR0JZb",
                                AppleMusic = "https://itunes.apple.com/au/album/the-ego-and-the-universe/1419799861"
                            }
                        },
                        Name = "21 Taras",
                        Bandcamp =  "https://21tarasband.bandcamp.com/",
                        SoundCloud = "https://soundcloud.com/21tarasband",
                        YouTube = "https://www.youtube.com/channel/UCgC0BYNIG1KDsqGoiu1iQoA",
                        Website =  "https://www.21tarasband.com/",
                        Twitter =  "https://twitter.com/21TarasBand",
                        Instagram = "https://www.instagram.com/21tarasband/",
                        Spotify = "https://open.spotify.com/artist/4dOLgFH6ffzCxazLksqHRh?",
                        ReverbNation =  "https://www.reverbnation.com/21Taras"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Rat in a Maze",
                                YouTube = "https://www.youtube.com/watch?v=SWTLh3U_VbI",
                                YouTubeMusic = "https://music.youtube.com/watch?v=SWTLh3U_VbI"
                            },
                            new Song
                            {
                                Name = "Run Away",
                                YouTubeMusic = "https://music.youtube.com/watch?v=ZZ-ezgTOqdA",
                                YouTube = "https://youtube.com/watch?v=ZZ-ezgTOqdA"
                            },
                            new Song
                            {
                                Name = "Simply Unknown",
                                YouTubeMusic = "https://music.youtube.com/watch?v=0coZbozsATA",
                                YouTube = "https://youtube.com/watch?v=0coZbozsATA"
                            },
                            new Song
                            {
                                Name = "Unhinged",
                                YouTubeMusic = "https://music.youtube.com/watch?v=pN7MnLVpsi0",
                                YouTube = "https://youtube.com/watch?v=pN7MnLVpsi0"
                            },
                            new Song
                            {
                                Name = "...Reprisal",
                                YouTubeMusic = "https://music.youtube.com/watch?v=M8R4o9Q_9wM",
                                YouTube = "https://youtube.com/watch?v=M8R4o9Q_9wM"
                            },
                            new Song
                            {
                                Name = "Mixed Emotions",
                                YouTubeMusic = "https://music.youtube.com/watch?v=MKqqwrm5bkY",
                                YouTube = "https://youtube.com/watch?v=MKqqwrm5bkY"
                            },
                            new Song
                            {
                                Name = "Lush",
                                YouTubeMusic = "https://music.youtube.com/watch?v=wi-AGQDVmwE",
                                YouTube = "https://youtube.com/watch?v=wi-AGQDVmwE"
                            },
                            new Song
                            {
                                Name = "Another Day",
                                YouTubeMusic = "https://music.youtube.com/watch?v=icdmf9cp-8E",
                                YouTube = "https://youtube.com/watch?v=icdmf9cp-8E",
                            }

                        },
                        Name = "7Daze",
                        Bandcamp =  "https://7daze.bandcamp.com/",
                        Twitter =  "https://twitter.com/7daze",
                        Facebook = "https://www.facebook.com/7DazeBand"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Jaded",
                                Spotify = "https://open.spotify.com/track/5AjEvb82v6V1B8cDBcjd1v",
                                YouTubeMusic = "https://music.youtube.com/watch?v=vOmcpoHIT8Y",
                                YouTube = "https://youtube.com/watch?v=vOmcpoHIT8Y"
                            },
                            new Song
                            {
                                Name = "TV Killed the Radio Star",
                                Spotify = "https://open.spotify.com/track/50Pd612L5fYj0fmkCHLS2h",
                                YouTubeMusic = "https://music.youtube.com/watch?v=Iqfiu6GAuG8",
                                YouTube = "https://youtube.com/watch?v=Iqfiu6GAuG8"
                            }

                        },
                        Name = "Across the Atlas",
                        Spotify = "https://open.spotify.com/artist/0vexPUHEmxcq4TDoZIU05M",
                        Facebook = "https://www.facebook.com/acrosstheatlas/",
                        Instagram = "https://www.instagram.com/acrosstheatlas/",
                        YouTube = "https://www.youtube.com/channel/UCWYMBr9uWZ-Vgu49sjrdh5w",
                        ReverbNation =  "https://www.reverbnation.com/acrosstheatlas",
                        SoundCloud = "https://soundcloud.com/acrosstheatlas",
                        Bandcamp =  "https://acrosstheatlas.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Last Shot",
                                Spotify = "https://open.spotify.com/track/62BjSUgYbddsWP4TO4uF8Z",
                                YouTubeMusic = "https://music.youtube.com/watch?v=Uw7OXczclBE",
                                YouTube = "https://youtube.com/watch?v=Uw7OXczclBE"
                            },
                            new Song
                            {
                                Name = "Always Forward",
                                Spotify = "https://open.spotify.com/track/7t3snGgyFDc2DUW6uNrXej",
                                YouTubeMusic = "https://music.youtube.com/watch?v=qJkel4DyYGg",
                                YouTube = "https://youtube.com/watch?v=qJkel4DyYGg"
                            },
                            new Song
                            {
                                Name = "Can't Argue",
                                Spotify = "https://open.spotify.com/track/2IIltlQvLZH8Q14fg352hx",
                                YouTubeMusic = "https://music.youtube.com/watch?v=e9i2Xj5oJrM",
                                YouTube = "https://youtube.com/watch?v=e9i2Xj5oJrM"
                            },
                            new Song
                            {
                                Name = "Adventures",
                                Spotify = "https://open.spotify.com/track/2eDxmnabWlzaMIPcmYSib2",

                            }

                        },
                        Name = "Alive Again",
                        Twitter =  "https://twitter.com/aliveagainmusic",
                        Bandcamp =  "https://aliveagain.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/aliveagain-1",
                        Facebook = "https://www.facebook.com/AliveAgainMusic",
                        Instagram = "https://www.instagram.com/aliveagainmusic",
                        Spotify = "https://open.spotify.com/artist/6Viw98QZPbKJtOkJNAPB2P",
                        YouTube = "https://www.youtube.com/user/AliveAgainOfficial"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Ginchy",
                                Spotify = "https://open.spotify.com/track/2fmk97MV8ua68s2kYqWzjH",
                                YouTubeMusic = "https://music.youtube.com/watch?v=AAvrSWSCGwM",
                                YouTube = "https://youtube.com/watch?v=AAvrSWSCGwM"
                            }
                        },
                        Name = "Balu & die Surfgrammeln",
                        Spotify = "https://open.spotify.com/artist/2pa880l04P19bv7PMpbcN4",
                        ReverbNation =  "https://www.reverbnation.com/baludiesurfgrammeln",
                        Facebook = "https://www.facebook.com/BaluUndSurfgrammeln/",
                        SoundCloud = "https://soundcloud.com/surfquartett",
                        Website =  "http://www.surfgrammeln-san.org/",
                        Bandcamp =  "https://greencookierecords.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "She Will be Known",
                                YouTubeMusic = "https://music.youtube.com/watch?v=DWZHgpz0oig",
                                YouTube = "https://youtube.com/watch?v=DWZHgpz0oig"
                            },
                            new Song
                            {
                                Name = "Give it All",
                                YouTubeMusic = "https://music.youtube.com/watch?v=CZ0gRNCiEjU",
                                YouTube = "https://youtube.com/watch?v=CZ0gRNCiEjU"
                            },
                            new Song
                            {
                                Name = "Love is Easy",
                            },
                            new Song
                            {
                                Name = "The Deal",
                            }
                        },
                        Name = "Banjax",
                        ReverbNation =  "https://www.reverbnation.com/banjaxuk",
                        Bandcamp =  "https://banjax.bandcamp.com",
                        YouTube = "https://www.youtube.com/banjaxuk",
                        Facebook = "https://www.facebook.com/banjaxuk",
                        Twitter =  "https://twitter.com/BanjaxUK"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "The Hour Between Dog and Wolf",
                                Spotify = "https://open.spotify.com/track/4UZf9QlctIIBYGvD0ioqrO",
                            }
                        },
                        Name = "BarCreeps",
                        Bandcamp =  "https://barcreeps.bandcamp.com/releases",
                        Facebook = "https://www.facebook.com/BarCreeps/",
                        Twitter =  "https://twitter.com/barcreepsband",
                        Spotify = "https://open.spotify.com/artist/4TYRMMe5TS85Gz7iG9yf7q",
                        SoundCloud = "https://soundcloud.com/barcreepsband"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Forest Walks",
                                Spotify = "https://open.spotify.com/track/088u8jMWU7eTeItEFsIX0w",
                                YouTubeMusic = "https://music.youtube.com/watch?v=80vr7O9NbgM",
                                YouTube = "https://youtube.com/watch?v=80vr7O9NbgM"
                            }
                        },
                        Name = "Bear Shoe",
                        Bandcamp =  "https://bearshoe.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/bearshoeband",
                        Instagram = "https://www.instagram.com/bearshoeband",
                        Twitter =  "https://twitter.com/BearShoeBand",
                        Spotify = "https://open.spotify.com/artist/4OehQTFb1Cw82lx0yyKhyl?",
                        Facebook = "https://www.facebook.com/bearshoeband/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "In My Head",
                                Spotify = "https://open.spotify.com/track/6HhjifmapSYKrlId6z3XNn",
                                YouTubeMusic = "https://music.youtube.com/watch?v=qOp_lZZIcwU",
                                YouTube = "https://youtube.com/watch?v=qOp_lZZIcwU"
                            }
                        },
                        Name = "Bedside Manners",
                        Spotify = "https://open.spotify.com/artist/5EoKWFeVYyDFH3ehZVx7sg",
                        Instagram = "https://www.instagram.com/bedsidemannersband/",
                        Twitter =  "https://twitter.com/BedsideOfficial",
                        Facebook = "https://www.facebook.com/bedsidemannersofficial/",
                        SoundCloud = "https://soundcloud.com/siixtil8"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Street Rat",
                                Spotify = "https://open.spotify.com/track/7tD7xLaVvxRUdEzXIqAA7w",
                                YouTubeMusic = "https://music.youtube.com/watch?v=UrBMZdT1_1w",
                                YouTube = "https://youtube.com/watch?v=UrBMZdT1_1w"
                            },
                            new Song
                            {
                                Name = "Sedgwick",
                                Spotify = "https://open.spotify.com/track/4X4I2SArIWIMd6s15HkJy2",
                                YouTubeMusic = "https://music.youtube.com/watch?v=O8DRo9y9qMQ",
                                YouTube = "https://youtube.com/watch?v=O8DRo9y9qMQ"
                            },
                            new Song
                            {
                                Name = "High Life",
                                Spotify = "https://open.spotify.com/track/39CMpF3LvpHFcejxTluHYM",
                                YouTubeMusic = "https://music.youtube.com/watch?v=u1pOEJJKuMg",
                                YouTube = "https://youtube.com/watch?v=u1pOEJJKuMg"
                            }

                        },
                        Name = "Bedspin",
                        Bandcamp =  "http://bedspin.bandcamp.com",
                        Instagram = "https://www.instagram.com/bedspinband",
                        Facebook = "https://www.facebook.com/bedspin618/",
                        Spotify = "https://open.spotify.com/artist/56THJ7K3NMQTkpWshTCqkW?"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Taps Aff",
                                Spotify = "https://open.spotify.com/track/33KTAQ1BCvRrh4Y2CwlK8k",
                                YouTubeMusic = "https://music.youtube.com/watch?v=j5Q3kmOwruQ",
                                YouTube = "https://youtube.com/watch?v=j5Q3kmOwruQ"
                            },
                            new Song
                            {
                                Name = "Your Superior (his inferior)",
                                YouTubeMusic = "https://music.youtube.com/watch?v=PlFvdXLtrtk",
                                YouTube = "https://youtube.com/watch?v=PlFvdXLtrtk"
                            }
                        },
                        Name = "Big Beard",
                        Bandcamp =  "https://bigbeard.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/6l1J1Pihggz4MJ5zTWconT?",
                        Facebook = "https://www.facebook.com/Big-Beard-165485510955489/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Animals",
                                Spotify = "https://open.spotify.com/track/1uLq8rN4NHpNXYbi4JfdEX",
                                YouTubeMusic = "https://music.youtube.com/watch?v=AY7jg3kE0UU",
                                YouTube = "https://youtube.com/watch?v=AY7jg3kE0UU"
                            },
                            new Song
                            {
                                Name = "Rooftops",
                                Spotify = "https://open.spotify.com/track/0nwYWJDuOz6EW71aR3ro8y",
                                YouTubeMusic = "https://music.youtube.com/watch?v=m-F8GPMPzbA",
                                YouTube = "https://youtube.com/watch?v=m-F8GPMPzbA"
                            },
                            new Song
                            {
                                Name = "Dead at 21",
                                Spotify = "https://open.spotify.com/track/4vWP2qTHuGH9WfLNxMEBqS",
                                YouTubeMusic = "https://music.youtube.com/watch?v=9Kn3kH-TYsc",
                                YouTube = "https://youtube.com/watch?v=9Kn3kH-TYsc"
                            },
                            new Song
                            {
                                Name = "Gasoline",
                                Spotify = "https://open.spotify.com/track/76msrzkd9Y2hDHv5NLpofg",
                                YouTubeMusic = "https://music.youtube.com/watch?v=E04mn-1yQEE",
                                YouTube = "https://youtube.com/watch?v=E04mn-1yQEE"
                            },
                            new Song
                            {
                                Name = "Ghost",
                                Spotify = "https://open.spotify.com/track/4HagQ43LqfxrjQ2hgB6XCU",
                                YouTubeMusic = "https://music.youtube.com/watch?v=bxgXXjPkkPA",
                                YouTube = "https://youtube.com/watch?v=bxgXXjPkkPA"
                            },
                            new Song
                            {
                                Name = "500",
                                Spotify = "https://open.spotify.com/track/3w3VG7hwvhqTM5d17s4d62",
                                YouTubeMusic = "https://music.youtube.com/watch?v=aFLDhd7nIKA",
                                Youtube = "https://youtube.com/watch?v=aFLDhd7nIKA"
                            },
                            new Song
                            {
                                Name = "Seven",
                                Spotify = "https://open.spotify.com/track/7INY6nq5D06yP2ZQOPC3C8",
                                YouTubeMusic = "https://music.youtube.com/watch?v=C949IYcdUBk",
                                YouTube = "https://youtube.com/watch?v=C949IYcdUBk"
                            },
                            new Song
                            {
                                Name = "Red",
                                Spotify = "https://open.spotify.com/track/4xbh3H6jXyGqlekWPiCPjR",
                                YouTubeMusic = "https://music.youtube.com/watch?v=ziqegNX-E60",
                                YouTube = "https://youtube.com/watch?v=ziqegNX-E60"
                            },
                            new Song
                            {
                                Name = "Repulsive Minds",
                                Spotify = "https://open.spotify.com/track/3Yv4bWqql22uC6lWBg3l1R",
                            },
                            new Song
                            {
                                Name = "L-X",
                                Spotify = "https://open.spotify.com/track/6bnTec10PJuKr1RRWQZKG1",
                                YouTubeMusic = "https://music.youtube.com/watch?v=gTDDxefiTqI",
                                YouTube = "https://youtube.com/watch?v=gTDDxefiTqI"
                            },
                            new Song
                            {
                                Name = "Depression",
                                Spotify = "https://open.spotify.com/track/6Sqn0M8WwuHttmOSDCTdjJ",
                            },
                            new Song
                            {
                                Name = "Suicide City",
                                Spotify = "https://open.spotify.com/track/4PxjoJ0yqPohLpv1rvxeSK",
                                YouTubeMusic = "https://music.youtube.com/watch?v=ATiO-DJr3fI",
                                YouTube = "https://youtube.com/watch?v=ATiO-DJr3fI"
                            },
                            new Song
                            {
                                Name = "These Hospital Halls",
                                Spotify = "https://open.spotify.com/track/0sCjpo5NuNi9XB8ziWSGAn",
                                YouTubeMusic = "https://music.youtube.com/watch?v=dAv7KXmemIQ",
                                YouTube = "https://youtube.com/watch?v=dAv7KXmemIQ"
                            },
                            new Song
                            {
                                Name = "Hank",
                                Spotify = "https://open.spotify.com/track/6Rqn7BrUEydjGPjPmmBdxa",
                                YouTubeMusic = "https://music.youtube.com/watch?v=0S66M483wLc",
                                YouTube = "https://youtube.com/watch?v=0S66M483wLc"
                            },
                            new Song
                            {
                                Name = "I Need a Doctor",
                                Spotify = "https://open.spotify.com/track/29zxqx21fTEN7vGUbVSkhk",
                                YouTubeMusic = "https://music.youtube.com/watch?v=9HA1_N996ts",
                                YouTube = "https://youtube.com/watch?v=9HA1_N996ts"
                            }

                        },
                        Name = "BRAINCOATS",
                        Spotify = "https://open.spotify.com/artist/7ej3r9Ru63d7mE2uzso1uE?",
                        Facebook = "https://www.facebook.com/BRAINCOATS/",
                        Bandcamp =  "https://braincoats.bandcamp.com/",
                        YouTube = "https://www.youtube.com/user/BraincoatsOfficial",
                        SoundCloud = "https://soundcloud.com/braincoats"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song {Name = "Her Parents"},
                            new Song
                            {
                                Name = "Two Minutes",
                                Spotify = "https://open.spotify.com/track/2RZ3iykgVdnK3rh2R3BMCI",
                                YouTubeMusic = "https://music.youtube.com/watch?v=6t2KVCaZpwA",
                                YouTube = "https://youtube.com/watch?v=n2DlK_ddWS4"
                            },
                            new Song
                            {
                                Name = "Day Job",
                                Spotify = "https://open.spotify.com/track/5zYLfGRszWWIp2HGfQtDPs",
                                YouTube = "https://music.youtube.com/watch?v=WFe-HbWfap0",
                                YouTube = "https://youtube.com/watch?v=7e7CKuWDOAQ"

                            },
                            new Song
                            {
                                Name = "Mothers & Fathers",
                                Spotify = "https://open.spotify.com/track/4FDkZIV7ecm8LAmMU5Etoy",
                                YouTubeMusic = "https://music.youtube.com/watch?v=pGKGyArmIjo",
                                YouTube = "https://youtube.com/watch?v=k-hwZfDTOeg"
                            },
                            new Song
                            {
                                Name = "Annabel",
                                Spotify = "https://open.spotify.com/track/5Yd5R5R3q1pEV1inAWbnP3",
                                YouTubeMusic = "https://music.youtube.com/watch?v=wYAsWMNa-n4",
                                YouTube = "https://music.youtube.com/watch?v=BRkMM9TjukI"
                            },
                        },
                        Name = "Brawlers",
                        Spotify = "https://open.spotify.com/artist/69tLgUPhogqUB7goY1kyJn?",
                        Facebook = "https://www.facebook.com/wearebrawlers/",
                        Twitter =  "https://twitter.com/wearebrawlers",
                        Website =  "http://www.ilovealcopop.co.uk/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "ESCapism",
                                YouTube = "https://youtube.com/watch?v=iA-W5sAlt0M"
                            }
                        },
                        Name = "Color Walls",
                        SoundCloud = "https://soundcloud.com/colorwalls",
                        Facebook = "https://www.facebook.com/colorwalls",
                        Instagram = "https://instagram.com/color.walls"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Dark Star",
                                Spotify = "https://open.spotify.com/track/2nOpdRWw86I4T5f42TTemT",
                                YouTube = "https://youtube.com/watch?v=XOhfM3MIMGo",
                                YouTubeMusic = "https://music.youtube.com/watch?v=MB0bqNrSgmQ"
                            },
                            new Song
                            {
                                Name = "Tyrannosaurus Hex",
                                Spotify = "https://open.spotify.com/track/7CYECvyqaE0Q2LqP9klpPq",
                                YouTubeMusic = "https://music.youtube.com/watch?v=OAtJaKG1LOM",
                                YouTube = "https://music.youtube.com/watch?v=IXVOuQIPlqw"
                            }
                        },
                        Name = "Cybernetic Witch Cult",
                        ReverbNation =  "https://www.reverbnation.com/cyberneticwitchcult",
                        Facebook = "https://www.facebook.com/cyberneticwitchcult",
                        Website =  "http://www.cyberneticwitchcult.com/",
                        Bandcamp =  "https://cyberneticwitchcult.bandcamp.com/",
                        SoundCloud = "https://soundcloud.com/cyberneticwitchcult"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Nico",
                                Spotify = "https://open.spotify.com/track/54IY6s74eXfwuwNE6Z8563",
                                YouTubeMusic = "https://music.youtube.com/watch?v=AFXhMEAkvr0",
                                YouTube = "https://music.youtube.com/watch?v=QFVyydWs8Fw"

                            }
                        },
                        Name = "The Dead Pirates",
                        Bandcamp =  "https://deadpirates.bandcamp.com/",
                        Website =  "http://thedeadpirates.com/",
                        Twitter =  "http://twitter.com/thedeadpirates",
                        Facebook = "http://www.facebook.com/thedeadpirates",
                        Instagram = "https://www.instagram.com/thedeadpirates",
                        Spotify = "https://open.spotify.com/artist/64bheP4lw6MvGJBNFKtPgx",
                        ReverbNation =  "https://www.reverbnation.com/deadpiratesusa"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Hopeless",
                                Spotify = "https://open.spotify.com/track/00p02sA0ukSepMOgpmNf3e",
                                YouTube = "https://youtube.com/watch?v=lWCqcIN0Y9g",
                                YouTubeMusic = "https://music.youtube.com/watch?v=k8FLJgTQlck"
                            },
                            new Song
                            {
                                Name = "Burning Hair",
                                Spotify = "https://open.spotify.com/track/6mYIPNzcMto2z9HP4qMQ2b",
                                YouTube = "https://youtube.com/watch?v=bMiV7Mvv2nU",
                                YouTubeMusic = "https://music.youtube.com/watch?v=bMiV7Mvv2nU"
                            }
                        },
                        Name = "Diamond in the Dirt",
                        Bandcamp =  "https://diamondinthedirt.bandcamp.com",
                        Facebook = "https://www.facebook.com/DiamondintheDirtUK",
                        Website =  "https://www.diamondinthedirtofficial.com/",
                        YouTube = "https://www.youtube.com/channel/UCRXs5lteOfIAv82dGnuKy6w",
                        Instagram = "https://instagram.com/DITDMUSIC",
                        Twitter =  "https://twitter.com/DITDMUSIC",
                        SoundCloud = "https://soundcloud.com/diamondinthedirtuk"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Anti-Social Syndrome",
                                Spotify = "https://open.spotify.com/track/3UgzSzPMCJv6XYemC32jbb",
                                YouTube = "https://youtube.com/watch?v=etdev6AvTZ4",
                            },
                            new Song
                            {
                                Name = "False Hope",
                                Spotify = "https://open.spotify.com/track/4x41390UE07xwu9tnbwsoS",
                                YouTube = "https://youtube.com/watch?v=i0rHJoGBDKE"
                            }
                        },
                        Name = "Downtown District",
                        Spotify = "https://open.spotify.com/artist/3CxM5oEzMim9SHteT3qjZN",
                        Website =  "https://www.emergenza.net/default.aspx?pag=399&nav=US&lng=en-us&band=266337",
                        Facebook = "https://www.facebook.com/DowntownDistrictBand/",
                        Twitter =  "https://twitter.com/kutband",
                        Instagram = "https://www.instagram.com/downtowndistrictband/",
                        YouTube = "https://www.youtube.com/channel/UCNXhLDSO1dzNiEOfO9R8Qtg",
                        SoundCloud = "https://soundcloud.com/downtowndistrict"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Solid Mass"
                            }
                        },
                        Name = "Evan Giesbrecht"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Nobody Cares but You",
                                YouTube = "https://youtube.com/watch?v=SIUy5P3WXHA"
                            }

                        },
                        Name = "The Filibusters",
                        Bandcamp =  "https://thefilibusters.bandcamp.com/",
                        Facebook = "https://www.facebook.com/thefilibusters/",
                        Website =  "http://www.thefilibusters.co.uk/",
                        SoundCloud = "https://soundcloud.com/the-filibusters-70793301",
                        YouTube = "https://www.youtube.com/channel/UCKb4BlGVwI6rFa89PiwbjlA"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Pay Day"
                            }
                        },
                        Name = "Fire Fences",
                        Bandcamp =  "https://firefences.bandcamp.com/",
                        Twitter =  "https://twitter.com/FireFences",
                        Website =  "https://www.firefences.com/",
                        Facebook = "https://www.facebook.com/firefences/",
                        ReverbNation =  "https://www.reverbnation.com/firefences",
                        YouTube = "https://www.youtube.com/user/FireFences",
                        Spotify = "https://open.spotify.com/artist/4g8tkj4ffRf8bPObnAuZTl"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {

                        },
                        Name = "Hoi-Poi Farplane Wind",
                        SoundCloud = "https://soundcloud.com/hoi_poi",
                        Instagram = "https://www.instagram.com/hoipoifarplanewind/",
                        Facebook = "https://www.facebook.com/hoi.poi.farplane.wind",
                        Bandcamp =  "https://hoi-poifarplanewind.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "The Last Great Train Robbery",
                                Spotify = "https://open.spotify.com/track/4Wi5BTtRNtX3mb2bDs1Vyi"
                            },
                            new Song
                            {
                                Name = "Tusen Takk",
                                Spotify = "https://open.spotify.com/track/4jKet3ukiejU77ViqeISxA"
                            },
                            new Song
                            {
                                Name = "Like Gravity",
                                Spotify = "https://open.spotify.com/track/6p3BFsLJVtkn7dAdN87atv"
                            },
                            new Song
                            {
                                Name = "Occams Razor",
                                Spotify = "https://open.spotify.com/track/17m1hJs4ixmqqbDyQ5fZWr"
                            },
                            new Song
                            {
                                Name = "Welcome Back to Nibelheim",
                                Spotify = "https://open.spotify.com/track/3AAZxnxkPXG19tL56cpeZG"
                            },
                            new Song
                            {
                                Name = "Hectares",
                                Spotify = "https://open.spotify.com/track/6tZHXVdr3cFOtQr0ctjG12"
                            },
                            new Song
                            {
                                Name = "This Fight",
                                Spotify = "https://open.spotify.com/track/79PADaB7EJQyIXrxHKsnRp"
                            },
                            new Song
                            {
                                Name = "Idiot Check",
                                Spotify = "https://open.spotify.com/track/6VwI8PsByeQHZZhQFOvDVo"
                            },
                            new Song
                            {
                                Name = "You Drove me to Taxidermy",
                                Spotify = "https://open.spotify.com/track/2o1GCDSBhcD7nGKZr0YNV1"
                            },
                            new Song
                            {
                                Name = "Magnetoscope",
                                Spotify = "https://open.spotify.com/track/2azOkfSFuPNv38m7qnbQZv"
                            },
                            new Song
                            {
                                Name = "Magnetoscope",
                                Spotify = "https://open.spotify.com/track/2azOkfSFuPNv38m7qnbQZv"
                            },
                            new Song
                            {
                                Name = "The People Are Revolting",
                                Spotify = "https://open.spotify.com/track/0vGsEh6gEQXPovWGk9v9jc"
                            },
                            new Song
                            {
                                Name = "Altogether Not Together",
                                Spotify = "https://open.spotify.com/track/5Wvqq3a6POzN3AJLEwzD1U"
                            },
                            new Song
                            {
                                Name = "Gunnar Hansen",
                                Spotify = "https://open.spotify.com/track/4Ge02OZyqwwqJI3WFPw8e0"
                            },
                            new Song
                            {
                                Name = "Captain Buzzkill",
                                Spotify = "https://open.spotify.com/track/6aambZWFjBEF0VjG6mvzqd"
                            },
                            new Song
                            {
                                Name = "Annotate My Fate",
                                Spotify = "https://open.spotify.com/track/1zsuwBqp2GliZjMtwjNBUp"
                            }
                        },
                        Name = "Freeze the Atlantic",
                        SoundCloud = "https://soundcloud.com/freezetheatlantic",
                        Facebook = "https://www.facebook.com/freezetheatlantic",
                        Website =  "https://www.freezetheatlantic.co.uk",
                        YouTube = "https://www.youtube.com/user/freezetheatlanticuk",
                        Spotify = "https://open.spotify.com/artist/4tEmJrqsn6ePHw8pbBz80B"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Thank You Polystyrene",
                                Spotify = "https://open.spotify.com/track/3qBgd6C4UhmM55JEvS86gr"
                            }
                        },
                        Name = "Helen Love",
                        Spotify = "https://open.spotify.com/artist/0ypZZtxEt7WJHjFIof8qWi",
                        Website =  "http://www.ilovealcopop.co.uk/artists/helen-love",
                        Bandcamp =  "https://helenlove.bandcamp.com/merch",
                        Twitter =  "https://twitter.com/HELENLOVE123"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Hollow Out a Horse",
                                Spotify = "https://open.spotify.com/track/2IEof9PZuXGjXIQr8riVWm"
                            },
                            new Song
                            {
                                Name = "Open Mic",
                                Spotify = "https://open.spotify.com/track/0iqdT5yVpfD51GcGkh0Okw"

                            },
                            new Song
                            {
                                Name = "There's a Man",
                                Spotify = "https://open.spotify.com/track/7vomxT43VX38GYqhmKTdQL"

                            },
                            new Song
                            {
                                Name = "Lithuanian Mercedes",
                                Spotify = "https://open.spotify.com/track/4wjKcNHalMq5sMNw9ETP3M"
                            },
                            new Song
                            {
                                Name = "Sir Puke",
                                Spotify = "https://open.spotify.com/track/67UjgVpS5rqXqtHFr4EPDP"
                            },
                            new Song
                            {
                                Name = "Justin Vernon",
                                Spotify = "https://open.spotify.com/track/4xCHlxRuGBV67Mjqmwj6D7"
                            },
                            new Song
                            {
                                Name = "Nietzsche",
                                Spotify = "https://open.spotify.com/track/63yTKrEjN8dqHc1l7lomUV"
                            },
                        },
                        Name = "Her Parents",
                        Bandcamp =  "https://herparents.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/herparents",
                        Twitter = "https://twitter.com/herparents",
                        Facebook = "https://www.facebook.com/herparentsband",
                        Spotify = "https://open.spotify.com/artist/3TT72KWJJAB7eI26351P1N"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Storm",
                                Spotify = "https://open.spotify.com/track/0vI4ZiKxYVnjxYH25lLxNR"
                            },
                            new Song
                            {
                                Name = "Charity for Nothing",
                                Spotify = "https://open.spotify.com/track/3tI0c34rIDa5XfeEgsfJ5r"
                            },
                            new Song
                            {
                                Name = "When Thoughts Collide",
                                Spotify = "https://open.spotify.com/track/2m7Kc3v1TgWfwbDy7V86UI"
                            },
                            new Song
                            {
                                Name = "Scream it Out Loud",
                                Spotify = "https://open.spotify.com/track/1BTZP3wYlQbjnq5L1QUGBc"
                            },
                            new Song
                            {
                                Name = "Restless",
                                Spotify = "https://open.spotify.com/track/6PpU93sDFfGMKiv21dNoxe"
                            },
                            new Song
                            {
                                Name = "Lonely One",
                                Spotify = "https://open.spotify.com/track/6MxcxUUOjCqDXgAQFoh8np"
                            },
                            new Song
                            {
                                Name = "Perfect World",
                                Spotify = "https://open.spotify.com/track/2CjWYDHW9LxOX5zrkyrQm4"
                            },
                            new Song
                            {
                                Name = "The Silence",
                                Spotify = "https://open.spotify.com/track/0URnJ5rvzVYRXkHu7CtOM0"
                            }
                        },
                        Name = "Heroic",
                        Website =  "https://www.heroicofficial.com",
                        Facebook = "https://www.facebook.com/heroicband/",
                        SoundCloud = "https://soundcloud.com/heroic-sweden",
                        AppleMusic =  "https://itunes.apple.com/se/artist/heroic/id26110616",
                        Spotify = "https://open.spotify.com/artist/5lkEJtA6Y1CVR1HP6hhYLN",
                        YouTube = "https://www.youtube.com/heroicsweden"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Lifetime Sentenced"
                            }
                        },
                        Name = "Hexed",
                        Facebook = "https://www.facebook.com/hexeduk",
                        Website =  "http://www.hexed4.wix.com/hexed",
                        Bandcamp =  "https://hexed1.bandcamp.com/",
                        Twitter =  "https://twitter.com/HEXEDUK",
                        ReverbNation =  "https://www.reverbnation.com/hexeduk"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Tempo",
                                Spotify = "https://open.spotify.com/track/6DU8kLZJHv1N3Bki2Uuzq7"
                            }
                        },
                        Name = "Husky Loops",
                        SoundCloud = "https://soundcloud.com/husky-loops",
                        Facebook = "https://www.facebook.com/huskyloops/",
                        Website =  "https://huskyloops.com/",
                        Bandcamp =  "https://huskyloops.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/1quz8ZBmFY2nzmoMcUXcX9"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "High Gear Death Drive",
                                Spotify = "https://open.spotify.com/track/0Z3tnFYZjlU9XPanAb9jOj"
                            }
                        },
                        Name = "InCircles",
                        YouTube = "https://youtube.com/incirclesmusic/",
                        Facebook = "https://www.facebook.com/incirclesmusic/",
                        Bandcamp =  "https://incirclesmusic.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/incirclesmusic",
                        ReverbNation =  "https://www.reverbnation.com/incirclesmusic"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "DeJa Vu" }
                        },
                        Name = "Jakobi",
                        SoundCloud = "https://soundcloud.com/jakobi_band",
                        Twitter =  "https://twitter.com/jakobi_band",
                        Facebook = "https://soundcloud.com/incirclesmusic"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Start" },
                            new Song { Name = "Better Left Unknown" },
                        },
                        Name = "James Gorringe",
                        Bandcamp =  "https://corrosionmedia.bandcamp.com",
                        YouTube = "https://www.youtube.com/user/CorrosionMedia"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Charlesyarnold" }
                        },
                        Name = "Jazzsub",
                        SoundCloud = "https://soundcloud.com/user7395477"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Little Bird",
                                Spotify = "https://open.spotify.com/track/1YRqGRjE2aw28A4eQj934b"
                            }
                        },
                        Name = "Jon Doe",
                        SoundCloud = "https://soundcloud.com/jondoeband",
                        Facebook = "https://www.facebook.com/jondoeofficial/",
                        Instagram = "https://www.instagram.com/jondoeofficial/",
                        YouTube = "https://www.youtube.com/channel/UCFUKMD3zyGH2pYwmC43eByQ",
                        Spotify = "https://open.spotify.com/artist/01VrPMFh7LXpXjf2Yie2xc"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {

                        },
                        Name = "LeSuits",
                        Facebook = "https://www.facebook.com/LeSuits",
                        ReverbNation =  "https://www.reverbnation.com/lesuits",
                        Spotify = "https://open.spotify.com/artist/4kpOr94kzKVOS81W4C62VG",
                        Bandcamp =  "https://lesuits.bandcamp.com/",
                        YouTube = "https://www.youtube.com/user/LeSuitsBand",
                        SoundCloud = "https://soundcloud.com/lesuits"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Are You Feeling This" }
                        },
                        Name = "look Mum No Computer",
                        YouTube = "https://www.youtube.com/channel/UCafxR2HWJRmMfSdyZXvZMTw",
                        Facebook = "https://www.facebook.com/LOOKMUMNOCOMPUTER/",
                        Instagram = "https://www.instagram.com/lookmumnocomputer/",
                        SoundCloud = "https://soundcloud.com/lookmumnocomputer"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "You're Pretty Short for a Stormtrooper",
                                Spotify = "https://open.spotify.com/track/2lclJHsiFawmFjRSZed1Wi"
                            },
                            new Song
                            {
                                Name = "Wake Up",
                                Spotify = "https://open.spotify.com/track/5PkDkC6xBSzfyNHAIy0KtW"
                            },
                            new Song
                            {
                                Name = "Back Off! Or Be Deleted!",
                                Spotify = "https://open.spotify.com/track/57krakvLa6IFt4v1KRyT0J"
                            }
                        },
                        Name = "The Majority Theives",
                        SoundCloud = "https://soundcloud.com/the-majority-thieves",
                        Facebook = "https://www.facebook.com/themajoritythieves",
                        Spotify = "https://open.spotify.com/artist/2OXVRyeRU6in6YK7QbYsPd",
                        Instagram = "https://instagram.com/https://instagram.com/the_majoritythieves_band/",
                        Twitter =  "https://twitter.com/MajorityThieves",
                        ReverbNation =  "https://www.reverbnation.com/themajoritythieves7"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Valentino", Spotify="https://open.spotify.com/track/5KyW4HmdUkrgL8ZwsIsrev" },
                            new Song { Name = "Wall of Death", Spotify = "https://open.spotify.com/track/0smTmNUMp21SpE1M9gZJGs" },
                            new Song { Name = "I'm Too Fat", Spotify = "https://open.spotify.com/track/7DYZNl6rfUfFenhT384lmG" },
                            new Song { Name = "Stamford Cowboys", Spotify = "https://open.spotify.com/track/3dmaEIv6HIRbb2iRrp2pAB" },
                            new Song { Name = "Big Bad Bob", Spotify = "https://open.spotify.com/track/5e4om7XUAaRQgAp7cUDRXV" },
                            new Song { Name = "For Your Life", Spotify = "https://open.spotify.com/track/6qYrpraii8EPNF6tJFDd9y" },
                            new Song { Name = "Drug Squad", Spotify = "https://open.spotify.com/track/5v4whJK0Qa1uZXG3xGk6Pj" },
                            new Song { Name = "Nervous State", Spotify = "https://open.spotify.com/track/0EPcvD65PF0Qz7iiOpxZCI" },
                            new Song { Name = "Stamford Stomp", Spotify = "https://open.spotify.com/track/1KLBy1vMBOoWWonAOXVCLj" },
                            new Song { Name = "BMX Haircut", Spotify = "https://open.spotify.com/track/5ENYCpaUzBads2zLh1JHkh" },
                            new Song { Name = "Whose Chicken?", Spotify = "https://open.spotify.com/track/7E58T38AfHzuu2gSadHa8w" },
                            new Song { Name = "Clash Culture", Spotify = "https://open.spotify.com/album/0hXaP7ixfT5LFK6INdxqBG" },
                            new Song { Name = "Nervous State, Pt. 3", Spotify = "https://open.spotify.com/track/5jxjFRb1JWjgWJsWGV8Uyy" },
                            new Song { Name = "Like I Do", Spotify = "https://open.spotify.com/track/2sQ2ktRYMAqcsbE9LjaSDb" },
                            new Song { Name = "The Job", Spotify = "https://open.spotify.com/track/0EfgceZUqw4ZVuiD65Ng4m" },
                            new Song { Name = "Cereal Killer", Spotify = "https://open.spotify.com/track/6KKaz21bCQQhw02axzRMiF" },
                            new Song { Name = "About You", Spotify = "https://open.spotify.com/track/6O3XtOj8INXt2tkWeatiZZ" },
                            new Song { Name = "Tonight", Spotify = "https://open.spotify.com/track/1rhofUPnnuZy7CAdqefgZI" },
                            new Song { Name = "Blues and Royals", Spotify = "https://open.spotify.com/track/2NfjWvgTfq1SdspgOT6unF" },
                            new Song { Name = "Wrong 1", Spotify = "https://open.spotify.com/track/1K8zb91ezvAga3sbCiWGSs" },
                            new Song { Name = "Norbert", Spotify = "https://open.spotify.com/track/0odB8n2oFm6JNnhG9Wdlge" },
                        },
                        Name = "March to the Grave",
                        Spotify = "https://open.spotify.com/artist/5YmqJGG8xIoOwAtV0gCLL1",
                        AppleMusic =  "https://itunes.apple.com/us/artist/march-to-the-grave/293740174",
                        Facebook = "https://www.facebook.com/groups/15191163875/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Stubborn", Spotify = "https://open.spotify.com/track/5K1hjOuuXP1jnhhF7sHEu5" },
                        },
                        Name = "Mega Happy",
                        Facebook = "https://www.facebook.com/megahappyband/",
                        Bandcamp =  "https://megahappy.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/3SK1XGbVxpwzbeK4tbunl8#_=_"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Vultures", Spotify = "https://open.spotify.com/track/4VjBBuvIEZTWGwKdMlYlof" },
                            new Song { Name = "Sleep With Your Friends", Spotify = "https://open.spotify.com/track/5hxMuuflOyvJKqFUwfLPd8" },
                            new Song { Name = "Don't Leave Me This Way", Spotify = "https://open.spotify.com/track/4SJ4YGx8WVR5jDLgkxAIEw" }
                        },
                        Name = "Murica",
                        Website =  "https://www.murica.co.uk",
                        Facebook = "https://www.facebook.com/muricaband",
                        Bandcamp =  "https://murica.bandcamp.com/",
                        ReverbNation =  "https://www.reverbnation.com/Murica",
                        Twitter =  "https://twitter.com/MuricaBand",
                        SoundCloud = "https://soundcloud.com/user-760885415",
                        YouTube = "https://www.youtube.com/channel/UCIc9SpqchQWxNRzwwe7Qq3Q",
                        Spotify = "https://open.spotify.com/artist/7L0oTSQ9gch8yI5gkV3kWi",
                        Instagram = "http://www.instagram.com/murica_music/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Fragile", Spotify = "https://open.spotify.com/track/5Yg0J6oGlvRQVE2lP4VKHw" }
                        },
                        Name = "Murmur",
                        Instagram = "https://www.instagram.com/murmur.4u/",
                        Facebook = "https://www.facebook.com/murmurbrighton",
                        SoundCloud = "https://soundcloud.com/murmurbrighton"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Ooh Name", Spotify = "https://open.spotify.com/track/2XeE8Cr3R6gq0gcXkdY4H6" },
                            new Song { Name = "Stay True to Yourself", Spotify = "https://open.spotify.com/track/0yQTfj5xzhXUADq1HTpNoQ" }
                        },
                        Name = "Noisy Way",
                        Bandcamp =  "https://noisyway.bandcamp.com",
                        Facebook = " https://www.facebook.com/noisyway",
                        SoundCloud = "https://soundcloud.com/noisyway",
                        Spotify = "https://open.spotify.com/artist/7F2aGtkB6l4jpGDI4EY7xG"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Dislocated", Spotify = "https://open.spotify.com/track/1VPX29cO6e8ZQ3ouct8hWb" },
                            new Song { Name = "I Guess This Is Progress", Spotify = "https://open.spotify.com/track/5K02LaCvFRvaGz547XvpW0" },
                            new Song { Name = "Reasons to Smile", Spotify = "https://open.spotify.com/track/49WGIXvhHYaUL4tpswBEWC" },
                            new Song { Name = "She's With You", Spotify = "https://open.spotify.com/track/7xDmOR4020DYGkWIpNmDsj" },
                            new Song { Name = "Goodbye Kiss", Spotify = "https://open.spotify.com/track/7uZQgC6NRlEyI77EyLhkPV" },
                            new Song { Name = "State of Confusion", Spotify = "https://open.spotify.com/track/522nEo2bfS2JG07OMV74yE" }

                        },
                        Name = "Not Tonight and the Headaches",
                        ReverbNation =  "https://www.reverbnation.com/nottonightandtheheadaches",
                        Facebook = "https://www.facebook.com/nottonightandtheheadaches/",
                        Spotify = "https://open.spotify.com/artist/4TjE8uCC9sZcUtEPu4PRo0",
                        Bandcamp =  "https://nottonightandtheheadaches.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Where Did I Go Wrong?", Spotify = "https://open.spotify.com/track/6dXJqDj4zYs0ACGCiCzRTX" },

                        },
                        Name = "Old Glory & The Back Riviera",
                        Spotify = "https://open.spotify.com/artist/6vaGH2y9yPJ1OTYfQZwG3M",
                        Instagram = "https://www.instagram.com/oldgloryandtheblackriviera/",
                        Facebook = "https://www.facebook.com/oldgloryandtheblackriviera/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Airplane", Spotify = "https://open.spotify.com/track/4Fk46Df38txNmCjK2NYgFd" },


                        },
                        Name = "Rescape",
                        Facebook = "https://www.facebook.com/RescapeOfficial",
                        Instagram = "https://www.instagram.com/rescapeofficial/",
                        YouTube = "https://www.youtube.com/channel/UCXXpZKiY8SSlkmPBg1B4eyA",
                        Twitter =  "https://twitter.com/RescapeOfficial",
                        SoundCloud = "https://soundcloud.com/RescapeOfficial",
                        Spotify = "https://open.spotify.com/artist/475AV9KmKsy8QdxMnyL16k"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Rrose Sélavy (To Make a Toast to Life)", Spotify = "https://open.spotify.com/track/6nj1JZVutvUlCNgqn4goDQ" },
                            new Song { Name = "The Establishment", Spotify = "https://open.spotify.com/track/1AMMsLbfnx0fYnuDPKB5Di" },
                        },
                        Name = "Revenge of the Psychotronic Man",
                        ReverbNation =  "https://www.reverbnation.com/revengeofthepsychotronicman",
                        Facebook = "https://www.facebook.com/RevengeofthePsychotronicMan/",
                        Website =  "https://revengeofthepsychotronicman.com/",
                        Bandcamp =  "https://revengeofthepsychotronicman.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/1oRwUuzzAy8m9DsVvCaAmT"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Hitchin em up" },
                            new Song { Name = "Tom Lambs Farm" },

                        },
                        Name = "Rick Simpson",
                        Bandcamp =  "https://ricksimpson.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Boys in Suits",
                                Spotify = "https://open.spotify.com/track/7lPxrttNRctXlwkBZ5xYpf"
                            }
                        },
                        Name = "Room D",
                        Instagram = "https://www.instagram.com/_room_d/",
                        Facebook = "https://www.facebook.com/RoomDBand/",
                        Bandcamp =  "https://roomd.bandcamp.com/releases",
                        Spotify = "https://open.spotify.com/artist/2pNGGUaw2rRAPz0FI71JIH"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Stuck",
                                Spotify = "https://open.spotify.com/track/7pGHVAdBTXiSgtB2Pc6LnQ"
                            },
                            new Song
                            {
                                Name = "Meant to Be",
                                Spotify = "https://open.spotify.com/track/4rKwlpgW0icYtIkfLMr1m8"
                            }
                        },
                        Name = "Second Opinion",
                        Bandcamp =  "https://secondopinionband.bandcamp.com",
                        Spotify = "https://open.spotify.com/artist/2ZJ2WlhjP3cu1lXKuz0pSC",
                        YouTube = "https://www.youtube.com/channel/UCiefctwVK83xVADai0Uk-6w",
                        Instagram = "https://www.instagram.com/secondopinion_band/",
                        SoundCloud = "https://soundcloud.com/second_opinion",
                        Twitter =  "https://twitter.com/SecondOpinionBE",
                        Facebook = "https://www.facebook.com/pg/SecondOpinionBand"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Brokenhearted", Spotify = "https://open.spotify.com/track/5tzTZUThyQROsRGz0YpmDp" }
                        },
                        Name = "Skittle Alley",
                        Website =  "http://www.skittlealley.de",
                        Facebook = "https://www.facebook.com/skittlealley/",
                        YouTube = "https://www.youtube.com/user/SkittleAlleyMusic",
                        Spotify = "https://open.spotify.com/artist/6xzJPV0Fn4UwCB78t8aaC7",
                        AppleMusic =  "https://itunes.apple.com/de/artist/skittle-alley/id1022969418",
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Snakes", Spotify = "https://open.spotify.com/track/36ipS3MDQsCVhzbG0DkluL" },
                            new Song { Name = "Cocodomore", Spotify = "https://open.spotify.com/track/3y05w9TjqesBn8i3DUVibM" },
                        },
                        Name = "St John's Ambiance",
                        Bandcamp =  "https://stjohnsambience.bandcamp.com",
                        Facebook = "https://www.facebook.com/StJohnsAmbience.Glasgow/",
                        SoundCloud = "https://soundcloud.com/st-johns-ambience"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Come Back", Spotify = "https://open.spotify.com/track/7lXGmspyH5PScuMhBSW2wh" },
                        },
                        Name = "Subtastics",
                        Facebook = "https://www.facebook.com/subtastics",
                        Bandcamp =  "https://subtastics.bandcamp.com/",
                        Twitter =  "https://twitter.com/subtastics",
                        Instagram = "https://www.instagram.com/subtastics/",
                        Website =  "https://www.snubbedrecords.com/",
                        Spotify = "https://open.spotify.com/artist/1fxv86YUmy6MG0U46eTnKc"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Lowlife" },
                            new Song { Name = "Gilbert" },
                        },
                        Name = "Swimming",
                        Bandcamp =  "https://swimmingswam.bandcamp.com/",
                        Instagram = "https://www.instagram.com/swimmingswam/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Punk Rock Flu", Spotify = "https://open.spotify.com/track/31vE1DzGSrg3x1VJMDcp1Z" },
                        },
                        Name = "The Friday Prophets",
                        Facebook = "https://www.facebook.com/pg/TheFridayProphets/",
                        Website =  "http://www.thefridayprophets.com/",
                        Instagram = "https://www.instagram.com/thefridayprophets/",
                        YouTube = "https://www.youtube.com/channel/UCN8c6skPGDx7oSZFKzJ4ijA",
                        SoundCloud = "https://soundcloud.com/the-friday-prophets",
                        Spotify = "https://open.spotify.com/artist/4HWtPkLYzL2fvWSuS1IHFp",
                        ReverbNation =  "https://www.reverbnation.com/thefridayprophets"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Let's Build a Home", Spotify = "https://open.spotify.com/track/1L2RBBrnjKZllCkNcgp4Ev" },
                            new Song { Name = "Snowsurfin", Spotify = "https://open.spotify.com/track/01C7uvsx2g1OEzpzhsqrqb" }
                        },
                        Name = "The Hops Party",
                        Facebook = "https://www.facebook.com/thehopsparty/",
                        Bandcamp =  "https://thehopsparty.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/0yUazoMydbFDI0LcyupSji"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Speedy Gonzales" },
                            new Song { Name = "Lightbulb" },
                            new Song { Name = "Chisel" },
                            new Song { Name = "I'm OK" },
                        },
                        Name = "The Rival",
                        Twitter =  "http://www.twitter.com/bobbyhalick",
                        SoundCloud = "http://soundcloud.com/therivalmusic"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Broken Guts", Spotify = "https://open.spotify.com/track/6yJTSLfUEKBA9GRG2KEgMW" }
                        },
                        Name = "The Spills",
                        Facebook = "https://www.facebook.com/thespills/",
                        Website =  "http://www.thespills.co.uk/",
                        Twitter =  "https://twitter.com/thespillsband",
                        YouTube = "https://www.youtube.com/channel/UCfG8kiHDeOczR5449-4qGgw",
                        Spotify = "https://open.spotify.com/artist/4I75d70tDjMNn2NAnp0I2E",
                        Bandcamp =  "https://thespills.bandcamp.com/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Get Through", Spotify = "https://open.spotify.com/track/5uh26LpOxHOFcl5DL6qjbe" },
                            new Song { Name = "Six Inches", Spotify = "https://open.spotify.com/track/24u5BbPjlUv8BSsGhhw6rU" }
                        },
                        Name = "The Suspicious Pigeons",
                        Bandcamp =  "https://thesuspiciouspigeons.bandcamp.com/releases",
                        Twitter =  "https://twitter.com/TheSPband_UK",
                        Instagram = "https://www.instagram.com/thesuspiciouspigeons/",
                        Facebook = "https://www.facebook.com/thesuspiciouspigeons"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "All I Need is to be Needed", Spotify = "https://open.spotify.com/track/2xUPpgi9t1NRzExh5IXQcZ" }
                        },
                        Name = "The Ultraviolet",
                        Bandcamp =  "https://theultravioletofficial.bandcamp.com/",
                        YouTube = "https://www.youtube.com/channel/UCaBjcuDQnMwkluZT89qxF5Q",
                        Instagram = "https://www.instagram.com/theultravioletofficial/",
                        Facebook = "https://www.facebook.com/theultraviolet.music",
                        Twitter =  "https://twitter.com/The_Ultraviolet",
                        Spotify = "https://open.spotify.com/artist/1NsIJ3z3RAHjQAPgDWzlIn"
                    },
                    new Band
                    {
                        Name = "The Wilbur Project",
                        Facebook = "https://www.facebook.com/groups/1118799074803360/",
                        Website =  "https://thewilburproject.co.uk"
                    },

                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Rolling On You Romeo",
                                Spotify = "https://open.spotify.com/track/7ph05MPYAnKlUQn61mYjfS"
                            }
                        },
                        Name = "VEI",
                        Spotify = "https://open.spotify.com/artist/0BYFpiq448iFqxmojCSxfq",
                        SoundCloud = "https://soundcloud.com/vei",
                        YouTube = "https://www.youtube.com/user/Veimusic",
                        Instagram = "https://www.instagram.com/vei_music/",
                        Facebook = "https://www.facebook.com/veimusicuk/",
                        Twitter =  "https://twitter.com/veimusic"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Valley of Vision", Spotify = "https://open.spotify.com/track/5Mc4gTsXRqHhCJ1snFFEPW" },
                            new Song { Name = "Old World Blues", Spotify = "https://open.spotify.com/track/0XaGk9PNgX0BLlRYWDIG2R" },
                        },
                        Name = "Weirds",
                        SoundCloud = "https://soundcloud.com/weirds",
                        Spotify = "https://open.spotify.com/artist/2lBeT2DTx7tg1GqZsbWYvy",
                        Twitter =  "https://twitter.com/weirdsband",
                        YouTube = "https://www.youtube.com/channel/UCxAeC498Qm76sKfzK_APMwA",
                        Facebook = "https://www.facebook.com/weirdsband/",
                        Instagram = "https://www.instagram.com/weirdstagram/"
                    },
                    new Band
                    {
                        Songs = new List<Song>()
                        {
                            new Song { Name = "Media", Spotify = "https://open.spotify.com/track/0sdzOt2j1Bd8TiEdWGu5P2" }
                        },
                        Name = "Zublue",
                        Facebook = "https://www.facebook.com/zublueband/",
                        SoundCloud = "https://soundcloud.com/zublue",
                        Instagram = "https://www.instagram.com/ZublueUK/",
                        Spotify = "https://open.spotify.com/artist/3UgmI3Q2tO0TQZyU7KPaf9?"
                    },
                    new Band
                    {
                        Name = "Red House Glory",
                        SoundCloud = "https://soundcloud.com/redhouseglory",
                        Twitter =  "https://twitter.com/redhouseglory",
                        YouTube = "https://www.youtube.com/user/RedHouseGlory?feature=watch",
                        ReverbNation =  "https://www.reverbnation.com/redhouseglory",
                        Spotify = "https://open.spotify.com/artist/5auBAjRV1CbWduf2FZLhKr?"
                    }
                };
                context.Bands.AddRange(bandList);
                context.SaveChanges();
            }
        }
    }
}