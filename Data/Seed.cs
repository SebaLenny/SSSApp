using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SSSApp.API.Models;

namespace SSSApp.API.Data
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            List<Driver> drivers = null;
            List<CarCategory> categories = null;
            List<Car> cars = null;
            List<Conditions> conditions = null;
            List<Track> tracks = null;
            List<Rally> rallies = null;
            List<RallyEntry> entries = null;
            List<Stage> stages = null;
            List<Result> results = null;
            List<Order> orders = null;
            List<Club> clubs = null;

            if (!context.Club.Any())
            {
                clubs = new List<Club>{
                    new Club{
                        ClubName = "Morszczuki"
                    }
                };
                context.Club.AddRange(clubs);
            }
            if (!context.Driver.Any())
            {
                drivers = new List<Driver>{
                    new Driver{
                        UserName = "SebaLenny",
                        FavouriteNumber = 13,
                        Club = clubs[0]
                    },
                    new Driver{
                        UserName = "Hypnosia",
                        FavouriteNumber = 27,
                        Club = clubs[0]
                    },
                    new Driver{
                        UserName = "Papryk",
                        FavouriteNumber = 2,
                        Club = clubs[0]
                    },
                    new Driver{
                        UserName = "Zibi",
                        FavouriteNumber = 69,
                        Club = clubs[0]
                    },
                    new Driver{
                        UserName = "Slomas",
                        FavouriteNumber = 69,
                        Club = clubs[0]
                    },
                };
                context.Driver.AddRange(drivers);
            }
            if (!context.Order.Any())
            {
                orders = new List<Order>
                {
                    new Order{Name="Best last"},
                    new Order{Name="Best first"},
                    new Order{Name="Signup order"},
                    new Order{Name="Random"},
                };
                context.Order.AddRange(orders);
            }
            if (!context.CarCategory.Any())
            {
                categories = new List<CarCategory>
                {
                    new CarCategory{CategoryName="R5"},
                    new CarCategory{CategoryName="WRC 2000cc"},
                    new CarCategory{CategoryName="Group B RWD"},
                    new CarCategory{CategoryName="Group B 4WD"},
                };
                context.CarCategory.AddRange(categories);
            }
            if (!context.Car.Any())
            {
                cars = new List<Car>
                {
                    new Car{
                        CarName="Ford Focus RS WRC",
                        CarCategory=categories.ElementAt(1)
                    },
                    new Car{
                        CarName="Peugeot 206 WRC",
                        CarCategory=categories.ElementAt(1)
                    },
                    new Car{
                        CarName="VW Polo GTI R5",
                        CarCategory=categories.ElementAt(0)
                    },
                    new Car{
                        CarName="Jelcz",
                        CarCategory=categories.ElementAt(3)
                    },
                };
                context.Car.AddRange(cars);
            }
            if (!context.Condition.Any())
            {
                conditions = new List<Conditions>
                {
                    new Conditions{Description="Dry"},
                    new Conditions{Description="Wet"},
                };
                context.Condition.AddRange(conditions);
            }
            if (!context.Track.Any())
            {
                tracks = new List<Track>
                {
                    new Track{TrackName="Pant Mawr"},
                    new Track{TrackName="JL Stelweld"},
                    new Track{TrackName="JL Pod Blokiem"},
                    new Track{TrackName="Kappar"},
                    new Track{TrackName="Kamienna"},
                };
                context.Track.AddRange(tracks);
            }
            if (!context.Rally.Any())
            {
                rallies = new List<Rally>
                {
                    new Rally{
                        RallyName="Klekotanie na plycie",
                        CarCategory=categories.ElementAt(3),
                        EventDate=new DateTime(2019, 12, 31),
                        Order=orders.ElementAt(0)
                    },
                    new Rally{
                        RallyName="SSS 20200202",
                        CarCategory=categories.ElementAt(1),
                        EventDate=new DateTime(2020, 2, 2),
                        Order=orders.ElementAt(1)
                    },
                };
                context.Rally.AddRange(rallies);
            }
            if (!context.Stage.Any())
            {
                stages = new List<Stage>
                {
                    new Stage{
                        Conditions=conditions.ElementAt(1),
                        Rally=rallies.ElementAt(0),
                        Track=tracks.ElementAt(1)
                    },
                    new Stage{
                        Conditions=conditions.ElementAt(1),
                        Rally=rallies.ElementAt(0),
                        Track=tracks.ElementAt(2)
                    },
                    new Stage{
                        Conditions=conditions.ElementAt(0),
                        Rally=rallies.ElementAt(1),
                        Track=tracks.ElementAt(0)
                    },
                    new Stage{
                        Conditions=conditions.ElementAt(0),
                        Rally=rallies.ElementAt(1),
                        Track=tracks.ElementAt(3)
                    },
                    new Stage{
                        Conditions=conditions.ElementAt(1),
                        Rally=rallies.ElementAt(1),
                        Track=tracks.ElementAt(4)
                    },
                };
                context.Stage.AddRange(stages);
            }
            if (!context.RallyEntry.Any())
            {
                entries = new List<RallyEntry>
                {
                    new RallyEntry{
                        Car=cars.ElementAt(3),
                        Driver=drivers.ElementAt(0),
                        Rally=rallies.ElementAt(0),
                        StartingNumber=drivers.ElementAt(0).FavouriteNumber
                    },
                    new RallyEntry{
                        Car=cars.ElementAt(3),
                        Driver=drivers.ElementAt(1),
                        Rally=rallies.ElementAt(0),
                        StartingNumber=drivers.ElementAt(1).FavouriteNumber
                    },
                };
                context.RallyEntry.AddRange(entries);
            }
            if (!context.Result.Any())
            {
                results = new List<Result>
                {
                    new Result{
                        DNF=false,
                        RallyEntry=entries.ElementAt(0),
                        Stage=stages.ElementAt(0),
                        Time=new TimeSpan(0,0,2,13,769)
                    },
                    new Result{
                        DNF=false,
                        RallyEntry=entries.ElementAt(1),
                        Stage=stages.ElementAt(0),
                        Time=new TimeSpan(0,0,2,14,423)
                    },
                    new Result{
                        DNF=false,
                        RallyEntry=entries.ElementAt(0),
                        Stage=stages.ElementAt(1),
                        Time=new TimeSpan(0,0,5,20,435)
                    },
                    new Result{
                        DNF=false,
                        RallyEntry=entries.ElementAt(1),
                        Stage=stages.ElementAt(1),
                        Time=new TimeSpan(0,0,5,14,346)
                    },
                };
                context.Result.AddRange(results);
            }

            context.SaveChanges();
        }
    }
}