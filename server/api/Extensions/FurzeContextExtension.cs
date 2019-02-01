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
                        Name = "Machine Gun Men",
                        Facebook = "https://www.facebook.com/MachineGunMen/",
                        Spotify = "https://open.spotify.com/artist/4nYqlHPagixAkYenxTEUm9",
                        Bandcamp =  "https://machinegunmen.bandcamp.com/",
                        ReverbNation =  "https://www.reverbnation.com/machinegunmen"
                    },
                    new Band
                    {
                        Name = "10 to Go",
                        Bandcamp =  "https://10togo.bandcamp.com/",
                        Facebook = "https://www.facebook.com/10TOGOBAND/",
                        SoundCloud = "https://soundcloud.com/10-to-go",
                        YouTube = "https://www.youtube.com/user/10TOGOBAND",
                        ReverbNation =  "https://www.reverbnation.com/10togoband",
                        Spotify = "https://open.spotify.com/artist/1DLBD6Rhp3kKjzamA9lULf?-a399psw1ZrGA"
                    },
                    new Band
                    {
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
                        Name = "7Daze",
                        Bandcamp =  "https://7daze.bandcamp.com/",
                        Twitter =  "https://twitter.com/7daze",
                        Facebook = "https://www.facebook.com/7DazeBand"
                    },
                    new Band
                    {
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
                        Name = "Alcopop Records"
                    },
                    new Band
                    {
                        Name = "Alive Again",
                        Twitter =  "https://twitter.com/aliveagainmusic",
                        Bandcamp =  "https://aliveagain.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/aliveagain-1",
                        Facebook = "https://www.facebook.com/AliveAgainMusic",
                        Instagram = "https://www.instagram.com/aliveagainmusic",
                        Spotify = "https://open.spotify.com/artist/6Viw98QZPbKJtOkJNAPB2P?-XdSKCYQS2EmTQAvA",
                        YouTube = "https://www.youtube.com/user/AliveAgainOfficial"
                    },
                    new Band
                    {
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
                        Name = "Banjax",
                        ReverbNation =  "https://www.reverbnation.com/banjaxuk",
                        Bandcamp =  "https://banjax.bandcamp.com",
                        YouTube = "https://www.youtube.com/banjaxuk",
                        Facebook = "https://www.facebook.com/banjaxuk",
                        Twitter =  "https://twitter.com/BanjaxUK"
                    },
                    new Band
                    {
                        Name = "Barcreeps",
                        Bandcamp =  "https://barcreeps.bandcamp.com/releases",
                        Facebook = "https://www.facebook.com/BarCreeps/",
                        Twitter =  "https://twitter.com/barcreepsband",
                        Spotify = "https://open.spotify.com/artist/4TYRMMe5TS85Gz7iG9yf7q?-Q",
                        SoundCloud = "https://soundcloud.com/barcreepsband"
                    },
                    new Band
                    {
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
                        Name = "Bedside Manners",
                        Spotify = "https://open.spotify.com/artist/5EoKWFeVYyDFH3ehZVx7sg",
                        Instagram = "https://www.instagram.com/bedsidemannersband/",
                        Twitter =  "https://twitter.com/BedsideOfficial",
                        Facebook = "https://www.facebook.com/bedsidemannersofficial/",
                        SoundCloud = "https://soundcloud.com/siixtil8"
                    },
                    new Band
                    {
                        Name = "Bedspin",
                        Bandcamp =  "http://bedspin.bandcamp.com",
                        Instagram = "https://www.instagram.com/bedspinband",
                        Facebook = "https://www.facebook.com/bedspin618/",
                        Spotify = "https://open.spotify.com/artist/56THJ7K3NMQTkpWshTCqkW?"
                    },
                    new Band
                    {
                        Name = "Big Beard",
                        Bandcamp =  "https://bigbeard.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/6l1J1Pihggz4MJ5zTWconT?",
                        Facebook = "https://www.facebook.com/Big-Beard-165485510955489/"
                    },
                    new Band
                    {
                        Name = "BRAINCOATS",
                        Spotify = "https://open.spotify.com/artist/7ej3r9Ru63d7mE2uzso1uE?",
                        Facebook = "https://www.facebook.com/BRAINCOATS/",
                        Bandcamp =  "https://braincoats.bandcamp.com/",
                        YouTube = "https://www.youtube.com/user/BraincoatsOfficial",
                        SoundCloud = "https://soundcloud.com/braincoats"
                    },
                    new Band
                    {
                        Name = "Brawlers",
                        Spotify = "https://open.spotify.com/artist/69tLgUPhogqUB7goY1kyJn?",
                        Facebook = "https://www.facebook.com/wearebrawlers/",
                        Twitter =  "https://twitter.com/wearebrawlers",
                        Website =  "http://www.ilovealcopop.co.uk/"
                    },
                    new Band
                    {
                        Name = "Color Walls",
                        SoundCloud = "https://soundcloud.com/colorwalls",
                        Facebook = "https://www.facebook.com/colorwalls",
                        Instagram = "https://instagram.com/color.walls"
                    },
                    new Band
                    {
                        Name = "Cybernetic Witch Cult",
                        ReverbNation =  "https://www.reverbnation.com/cyberneticwitchcult",
                        Facebook = "https://www.facebook.com/cyberneticwitchcult",
                        Website =  "http://www.cyberneticwitchcult.com/",
                        Bandcamp =  "https://cyberneticwitchcult.bandcamp.com/",
                        SoundCloud = "https://soundcloud.com/cyberneticwitchcult"
                    },
                    new Band
                    {
                        Name = "Dead Pirates",
                        Bandcamp =  "https://deadpirates.bandcamp.com/",
                        Website =  "http://thedeadpirates.com/",
                        Twitter =  "http://twitter.com/thedeadpirates",
                        Facebook = "http://www.facebook.com/thedeadpirates",
                        Instagram = "https://www.instagram.com/thedeadpirates",
                        Spotify = "https://open.spotify.com/artist/64bheP4lw6MvGJBNFKtPgx?-zqRqiWMDonX19ziw",
                        ReverbNation =  "https://www.reverbnation.com/deadpiratesusa"
                    },
                    new Band
                    {
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
                        Name = "Evan Giesbrecht"
                    },
                    new Band
                    {
                        Name = "The Filibusters",
                        Bandcamp =  "https://thefilibusters.bandcamp.com/",
                        Facebook = "https://www.facebook.com/thefilibusters/",
                        Website =  "http://www.thefilibusters.co.uk/",
                        SoundCloud = "https://soundcloud.com/the-filibusters-70793301",
                        YouTube = "https://www.youtube.com/channel/UCKb4BlGVwI6rFa89PiwbjlA"
                    },
                    new Band
                    {
                        Name = "Fire Fences",
                        Bandcamp =  "https://firefences.bandcamp.com/",
                        Twitter =  "https://twitter.com/FireFences",
                        Website =  "https://www.firefences.com/",
                        Facebook = "https://www.facebook.com/firefences/",
                        ReverbNation =  "https://www.reverbnation.com/firefences",
                        YouTube = "https://www.youtube.com/user/FireFences",
                        Spotify = "https://open.spotify.com/artist/4g8tkj4ffRf8bPObnAuZTl?si=7iqujzDDQGW5qK7m1XfPTA"
                    },
                    new Band
                    {
                        Name = "Hoi-Poi Farplane Wind",
                        SoundCloud = "https://soundcloud.com/hoi_poi",
                        Instagram = "https://www.instagram.com/hoipoifarplanewind/",
                        Facebook = "https://www.facebook.com/hoi.poi.farplane.wind",
                        Bandcamp =  "https://hoi-poifarplanewind.bandcamp.com/"
                    },
                    new Band
                    {
                        Name = "Freeze the Atlantic",
                        SoundCloud = "https://soundcloud.com/freezetheatlantic",
                        Facebook = "https://www.facebook.com/freezetheatlantic",
                        Website =  "https://www.freezetheatlantic.co.uk",
                        YouTube = "https://www.youtube.com/user/freezetheatlanticuk",
                        Spotify = "https://open.spotify.com/artist/4tEmJrqsn6ePHw8pbBz80B?si=12CZ1j8FRfC3N4XSuuwfRw"
                    },
                    new Band
                    {
                        Name = "Helen Love",
                        Spotify = "https://open.spotify.com/artist/0ypZZtxEt7WJHjFIof8qWi",
                        Website =  "http://www.ilovealcopop.co.uk/artists/helen-love",
                        Bandcamp =  "https://helenlove.bandcamp.com/merch",
                        Twitter =  "https://twitter.com/HELENLOVE123"
                    },
                    new Band
                    {
                        Name = "Her Parents",
                        Bandcamp =  "https://herparents.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/herparents",
                        Twitter = "https://twitter.com/herparents",
                        Facebook = "https://www.facebook.com/herparentsband",
                        Spotify = "https://open.spotify.com/artist/3TT72KWJJAB7eI26351P1N?si=qVqIQyi3Qi6P47liD7xzyw"
                    },
                    new Band
                    {
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
                        Name = "Hexed",
                        Facebook = "https://www.facebook.com/hexeduk",
                        Website =  "http://www.hexed4.wix.com/hexed",
                        Bandcamp =  "https://hexed1.bandcamp.com/",
                        Twitter =  "https://twitter.com/HEXEDUK",
                        ReverbNation =  "https://www.reverbnation.com/hexeduk"
                    },
                    new Band
                    {
                        Name = "Husky Loops",
                        SoundCloud = "https://soundcloud.com/husky-loops",
                        Facebook = "https://www.facebook.com/huskyloops/",
                        Website =  "https://huskyloops.com/",
                        Bandcamp =  "https://huskyloops.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/1quz8ZBmFY2nzmoMcUXcX9?si=An9GeemjRMObyxE9AfgiTQ"
                    },
                    new Band
                    {
                        Name = "InCircles",
                        YouTube = "https://youtube.com/incirclesmusic/",
                        Facebook = "https://www.facebook.com/incirclesmusic/",
                        Bandcamp =  "https://incirclesmusic.bandcamp.com",
                        SoundCloud = "https://soundcloud.com/incirclesmusic",
                        ReverbNation =  "https://www.reverbnation.com/incirclesmusic"
                    },
                    new Band
                    {
                        Name = "Jakobi",
                        SoundCloud = "https://soundcloud.com/jakobi_band",
                        Twitter =  "https://twitter.com/jakobi_band",
                        Facebook = "https://soundcloud.com/incirclesmusic"
                    },
                    new Band {
                        Name = "James Gorringe",
                        Bandcamp =  "https://corrosionmedia.bandcamp.com",
                        YouTube = "https://www.youtube.com/user/CorrosionMedia"
                    },
                    new Band
                    {
                        Name = "Jazzsub",
                        SoundCloud = "https://soundcloud.com/user7395477"
                    },
                    new Band
                    {
                        Name = "Jon Doe",
                        SoundCloud = "https://soundcloud.com/jondoeband",
                        Facebook = "https://www.facebook.com/jondoeofficial/",
                        Instagram = "https://www.instagram.com/jondoeofficial/",
                        YouTube = "https://www.youtube.com/channel/UCFUKMD3zyGH2pYwmC43eByQ",
                        Spotify = "https://open.spotify.com/artist/01VrPMFh7LXpXjf2Yie2xc?si=X5vauyNnQYq4XHiTfIfrww"
                    },
                    new Band
                    {
                        Name = "LeSuits",
                        Facebook = "https://www.facebook.com/LeSuits",
                        ReverbNation =  "https://www.reverbnation.com/lesuits",
                        Spotify = "https://open.spotify.com/artist/4kpOr94kzKVOS81W4C62VG?si=APDd8VULQfqFxYkdWTktag",
                        Bandcamp =  "https://lesuits.bandcamp.com/",
                        YouTube = "https://www.youtube.com/user/LeSuitsBand",
                        SoundCloud = "https://soundcloud.com/lesuits"
                    },
                    new Band
                    {
                        Name = "look Mum No Computer",
                        YouTube = "https://www.youtube.com/channel/UCafxR2HWJRmMfSdyZXvZMTw",
                        Facebook = "https://www.facebook.com/LOOKMUMNOCOMPUTER/",
                        Instagram = "https://www.instagram.com/lookmumnocomputer/",
                        SoundCloud = "https://soundcloud.com/lookmumnocomputer"
                    },
                    new Band
                    {
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
                        Name = "March to the Grave",
                        Spotify = "https://open.spotify.com/artist/5YmqJGG8xIoOwAtV0gCLL1?si=FM28pNc4SjGDnjtVGxL1Lw",
                        AppleMusic =  "https://itunes.apple.com/us/artist/march-to-the-grave/293740174",
                        Facebook = "https://www.facebook.com/groups/15191163875/"
                    },
                    new Band
                    {
                        Name = "Mega Happy",
                        Facebook = "https://www.facebook.com/megahappyband/",
                        Bandcamp =  "https://megahappy.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/3SK1XGbVxpwzbeK4tbunl8#_=_"
                    },
                    new Band
                    {
                        Name = "Murica",
                        Website =  "https://www.murica.co.uk",
                        Facebook = "https://www.facebook.com/muricaband",
                        Bandcamp =  "https://murica.bandcamp.com/",
                        ReverbNation =  "https://www.reverbnation.com/Murica",
                        Twitter =  "https://twitter.com/MuricaBand",
                        SoundCloud = "https://soundcloud.com/user-760885415",
                        YouTube = "https://www.youtube.com/channel/UCIc9SpqchQWxNRzwwe7Qq3Q",
                        Spotify = "https://open.spotify.com/artist/7L0oTSQ9gch8yI5gkV3kWi?si=SaA9dr_PQwmD_gwq3PRqPQ",
                        Instagram = "http://www.instagram.com/murica_music/"
                    },
                    new Band
                    {
                        Name = "Murmur",
                        Instagram = "https://www.instagram.com/murmur.4u/",
                        Facebook = "https://www.facebook.com/murmurbrighton",
                        SoundCloud = "https://soundcloud.com/murmurbrighton"
                    },
                    new Band
                    {
                        Name = "Noisy Way",
                        Bandcamp =  "https://noisyway.bandcamp.com",
                        Facebook = " https://www.facebook.com/noisyway",
                        SoundCloud = "https://soundcloud.com/noisyway",
                        Spotify = "https://open.spotify.com/artist/7F2aGtkB6l4jpGDI4EY7xG?si=k5-_GZPeQQe9BNZZ131dRw"
                    },
                    new Band
                    {
                        Name = "Not Tonight and the Headaches",
                        ReverbNation =  "https://www.reverbnation.com/nottonightandtheheadaches",
                        Facebook = "https://www.facebook.com/nottonightandtheheadaches/",
                        Spotify = "https://open.spotify.com/artist/4TjE8uCC9sZcUtEPu4PRo0?si=zBSs39jDRECr8S8h1ijzEQ",
                        Bandcamp =  "https://nottonightandtheheadaches.bandcamp.com/"
                    },
                    new Band
                    {
                        Name = "Old Glory & The Back Riviera",
                        Instagram = "https://www.instagram.com/oldgloryandtheblackriviera/",
                        Facebook = "https://www.facebook.com/oldgloryandtheblackriviera/"
                    },
                    new Band
                    {
                        Name = "Rescape",
                        Facebook = "https://www.facebook.com/RescapeOfficial",
                        Instagram = "https://www.instagram.com/rescapeofficial/",
                        YouTube = "https://www.youtube.com/channel/UCXXpZKiY8SSlkmPBg1B4eyA",
                        Twitter =  "https://twitter.com/RescapeOfficial",
                        SoundCloud = "https://soundcloud.com/RescapeOfficial",
                        Spotify = "https://open.spotify.com/artist/475AV9KmKsy8QdxMnyL16k?si=26qEvqYUTgKXNpLsHv4tLQ"
                    },
                    new Band
                    {
                        Name = "Revenge of the Psychotronic Man",
                        ReverbNation =  "https://www.reverbnation.com/revengeofthepsychotronicman",
                        Facebook = "https://www.facebook.com/RevengeofthePsychotronicMan/",
                        Website =  "https://revengeofthepsychotronicman.com/",
                        Bandcamp =  "https://revengeofthepsychotronicman.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/1oRwUuzzAy8m9DsVvCaAmT?si=MgJWx4khRqy-GKSVAmuE4g"
                    },
                    new Band
                    {
                        Name = "Rick Simpson",
                        Bandcamp =  "https://ricksimpson.bandcamp.com/"
                    },
                    new Band
                    {
                        Name = "RoomD",
                        Instagram = "https://www.instagram.com/_room_d/",
                        Facebook = "https://www.facebook.com/RoomDBand/",
                        Bandcamp =  "https://roomd.bandcamp.com/releases",
                        Spotify = "https://open.spotify.com/artist/2pNGGUaw2rRAPz0FI71JIH?si=OHSdaDVFRbuqL9L1tc4WLg"
                    },
                    new Band
                    {
                        Name = "Second Opinion",
                        Bandcamp =  "https://secondopinionband.bandcamp.com",
                        Spotify = "https://open.spotify.com/artist/2ZJ2WlhjP3cu1lXKuz0pSC?si=q3W3OlnwSpexAYwlxlNnkA",
                        YouTube = "https://www.youtube.com/channel/UCiefctwVK83xVADai0Uk-6w",
                        Instagram = "https://www.instagram.com/secondopinion_band/",
                        SoundCloud = "https://soundcloud.com/second_opinion",
                        Twitter =  "https://twitter.com/SecondOpinionBE",
                        Facebook = "https://www.facebook.com/pg/SecondOpinionBand"
                    },
                    new Band
                    {
                        Name = "Skittle Alley",
                        Website =  "http://www.skittlealley.de",
                        Facebook = "https://www.facebook.com/skittlealley/",
                        YouTube = "https://www.youtube.com/user/SkittleAlleyMusic",
                        Spotify = "https://open.spotify.com/artist/6xzJPV0Fn4UwCB78t8aaC7",
                        AppleMusic =  "https://itunes.apple.com/de/artist/skittle-alley/id1022969418",
                    },
                    new Band
                    {
                        Name = "St Johns Ambiance",
                        Bandcamp =  "https://stjohnsambience.bandcamp.com",
                        Facebook = "https://www.facebook.com/StJohnsAmbience.Glasgow/",
                        SoundCloud = "https://soundcloud.com/st-johns-ambience"
                    },
                    new Band
                    {
                        Name = "Subtastics",
                        Facebook = "https://www.facebook.com/subtastics",
                        Bandcamp =  "https://subtastics.bandcamp.com/",
                        Twitter =  "https://twitter.com/subtastics",
                        Instagram = "https://www.instagram.com/subtastics/",
                        Website =  "https://www.snubbedrecords.com/",
                        Spotify = "https://open.spotify.com/artist/1fxv86YUmy6MG0U46eTnKc?si=4eaIX-p-RjOOb76E24MyYg"
                    },
                    new Band
                    {
                        Name = "Swimming",
                        Bandcamp =  "https://swimmingswam.bandcamp.com/",
                        Instagram = "https://www.instagram.com/swimmingswam/"
                    },
                    new Band
                    {
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
                        Name = "The Hops Party",
                        Facebook = "https://www.facebook.com/thehopsparty/",
                        Bandcamp =  "https://thehopsparty.bandcamp.com/",
                        Spotify = "https://open.spotify.com/artist/0yUazoMydbFDI0LcyupSji?si=CGprEZQ9TYuBo0l_HqeebQ"
                    },
                    new Band
                    {
                        Name = "The Rival",
                        Twitter =  "http://www.twitter.com/bobbyhalick",
                        SoundCloud = "http://soundcloud.com/therivalmusic"
                    },
                    new Band
                    {
                        Name = "The Spills",
                        Facebook = "https://www.facebook.com/thespills/",
                        Website =  "http://www.thespills.co.uk/",
                        Twitter =  "https://twitter.com/thespillsband",
                        YouTube = "https://www.youtube.com/channel/UCfG8kiHDeOczR5449-4qGgw",
                        Spotify = "https://open.spotify.com/artist/4I75d70tDjMNn2NAnp0I2E?si=698x0CMDR52dwLbLv_Wj5g",
                        Bandcamp =  "https://thespills.bandcamp.com/"
                    },
                    new Band
                    {
                        Name = "The Suspicious Pigeons",
                        Bandcamp =  "https://thesuspiciouspigeons.bandcamp.com/releases",
                        Twitter =  "https://twitter.com/TheSPband_UK",
                        Instagram = "https://www.instagram.com/thesuspiciouspigeons/",
                        Facebook = "https://www.facebook.com/thesuspiciouspigeons"
                    },
                    new Band
                    {
                        Name = "The Ultraviolet",
                        Bandcamp =  "https://theultravioletofficial.bandcamp.com/",
                        YouTube = "https://www.youtube.com/channel/UCaBjcuDQnMwkluZT89qxF5Q",
                        Instagram = "https://www.instagram.com/theultravioletofficial/",
                        Facebook = "https://www.facebook.com/theultraviolet.music",
                        Twitter =  "https://twitter.com/The_Ultraviolet",
                        Spotify = "https://open.spotify.com/artist/1NsIJ3z3RAHjQAPgDWzlIn?si=3DdsX0CFSkeB0X1FcNG9NA"
                    },
                    new Band
                    {
                        Name = "The Wilbur Project",
                        Facebook = "https://www.facebook.com/groups/1118799074803360/",
                        Website =  "https://thewilburproject.co.uk"
                    },

                    new Band
                    {
                        Name = "VEI",
                        SoundCloud = "https://soundcloud.com/vei",
                        YouTube = "https://www.youtube.com/user/Veimusic",
                        Instagram = "https://www.instagram.com/vei_music/",
                        Facebook = "https://www.facebook.com/veimusicuk/",
                        Twitter =  "https://twitter.com/veimusic"
                    },
                    new Band
                    {
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