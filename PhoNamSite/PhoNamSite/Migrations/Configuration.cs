namespace PhoNamSite.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoNamSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoNamSite.Models.ApplicationDbContext context)
        {
            //    new List<Category>
            //    {
            //        new Category
            //        {
            //            CategoryID = 1,
            //            CategoryName = "Appetizers",
            //        },
            //        new Category
            //        {
            //            CategoryID = 2,
            //            CategoryName = "VietnameseNoodleSoups"
            //        },
            //        new Category
            //        {
            //            CategoryID = 3,
            //            CategoryName = "OrientalNoodleSoup"
            //        },
            //        new Category
            //        {
            //            CategoryID = 4,
            //            CategoryName = "VietnameseRiceVermicelli"
            //        },
            //        new Category
            //        {
            //            CategoryID = 5,
            //            CategoryName = "RiceDishes"
            //        },
            //        new Category
            //        {
            //            CategoryID = 6,
            //            CategoryName = "StirFriedNoodles"
            //        },
            //        new Category
            //        {
            //            CategoryID = 7,
            //            CategoryName = "Vegetarian"
            //        },
            //        new Category
            //        {
            //            CategoryID = 8,
            //            CategoryName = "Desserts"
            //        },
            //        new Category
            //        {
            //            CategoryID = 9,
            //            CategoryName = "Beverages"
            //        }
            //    }.ForEach(p => context.Categories.Add(p));


            //    new List<MenuProduct>
            //    {
            //     new MenuProduct
            //     {
            //            ProductID = 1,
            //            MenuID = "1",
            //            ProductName = "Egg Rolls",
            //            Description = "Ground Pork, Egg, and Assorted Vegetable filling",
            //            UnitPrice = 3.25,
            //            ImagePath = null,
            //            CategoryID = 1
            //        },
            //    new MenuProduct
            //    {
            //        ProductID = 2,
            //        MenuID = "2",
            //        ProductName = "Spring Rolls",
            //        Description = "Shrimp, Pork, Rice Noodle, and Assorted Vegetable Filling",
            //        ImagePath = null,
            //        UnitPrice = 3.55,
            //        CategoryID = 1
            //    },

            //    new MenuProduct
            //    {
            //        ProductID = 3,
            //        MenuID = "3",
            //        ProductName = "Fried Chicken Wings",
            //        Description = "Wings ",
            //        ImagePath = null,
            //        UnitPrice = 4.55,
            //        CategoryID = 1
            //    },
            //        new MenuProduct
            //        {
            //            ProductID = 4,
            //            MenuID = "4",
            //            ProductName = "Fried Wontons",
            //            Description = "Mixed Chicken, pork, onion",
            //            ImagePath = null,
            //            UnitPrice = 4.25,
            //            CategoryID = 1
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 5,
            //            MenuID = "5",
            //            ProductName = "Fried Tofu with Lemongrass",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 4.25,
            //            CategoryID = 1
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 6,
            //            MenuID = "6A",
            //            ProductName = "Vietnamese BBQ Pork Meatballs",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 4.75,
            //            CategoryID = 1
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 7,
            //            MenuID = "6B",
            //            ProductName = "Papaya Salad",
            //            Description = "Green Papaya, Shrimp, Pork",
            //            ImagePath = null,
            //            UnitPrice = 4.75,
            //            CategoryID = 1
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 8,
            //            MenuID = "6C",
            //            ProductName = "Shredded Pork Salad Rolls",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 3.55,
            //            CategoryID = 1
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 9,
            //            MenuID = "7",
            //            ProductName = "Hot & Spicy Rice Noodle Soup with Beef",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 9.75,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 10,
            //            MenuID = "8",
            //            ProductName = "Pho with Beef Fillet",
            //            Description = "Noodle Soup with Beef",
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 11,
            //            MenuID = "9",
            //            ProductName = "Pho with Beef Well-Done Flank",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 12,
            //            MenuID = "10",
            //            ProductName = "Pho with Beef Fillet and Soft Tendon",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 8.75,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 13,
            //            MenuID = "11",
            //            ProductName = "Pho with Beef Meatballs",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 8.25,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 14,
            //            MenuID = "12",
            //            ProductName = "Pho with Beef Fillet and Meatball",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 8.75,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 15,
            //            MenuID = "13",
            //            ProductName = "Pho with Shredded Chicken",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 16,
            //            MenuID = "14",
            //            ProductName = "Pho Nam Noodle House Deluxe",
            //            Description = "Noodle soup with sliced beef, meatballs, flank, tripe, and soft tendon",
            //            ImagePath = null,
            //            UnitPrice = 8.95,
            //            CategoryID = 2
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 17,
            //            MenuID = "15",
            //            ProductName = "Wonton Soup",
            //            Description = "Mixed chicken, pork, and onion wontons",
            //            ImagePath = null,
            //            UnitPrice = 7.55,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 18,
            //            MenuID = "16",
            //            ProductName = "Chicken Cellophane Noodle Soup",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 8.25,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 19,
            //            MenuID = "17",
            //            ProductName = "Egg Noodle and Wonton Soup with BBQ Roast Pork",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 8.25,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 20,
            //            MenuID = "18",
            //            ProductName = "Egg Noodle Soup with Chicken",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 21,
            //            MenuID = "19",
            //            ProductName = "Rice Noodle Soup with BBQ Roast Pork",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 22,
            //            MenuID = "20",
            //            ProductName = "Egg Noodle Soup with BBQ Roast Pork",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 23,
            //            MenuID = "21",
            //            ProductName = "Rice Noodle Soup with Seafood",
            //            Description = "Shrimp, Squid, Fish balls, and Scallops",
            //            ImagePath = null,
            //            UnitPrice = 9.50,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 24,
            //            MenuID = "22",
            //            ProductName = "Egg Noodle Soup with Seafood",
            //            Description = "Shrimp, Squid, Fish Balls, and Scallops",
            //            ImagePath = null,
            //            UnitPrice = 9.50,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 25,
            //            MenuID = "23",
            //            ProductName = "Tapioca Noodle Chicken Soup",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 26,
            //            MenuID = "24",
            //            ProductName = "Tapioca Noodle soup with Shrimp, Pork",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 9.25,
            //            CategoryID = 3
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 27,
            //            MenuID = "25",
            //            ProductName = "Beef Vermicelli Noodle",
            //            Description = "Stir fried lemon grass beef topped with peanut and vegetables",
            //            ImagePath = null,
            //            UnitPrice = 8.55,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 28,
            //            MenuID = "25A",
            //            ProductName = "Tofu Vermicelli Noodle",
            //            Description = "Stir fried lemon grass tofu topped with peanut and vegetables",
            //            ImagePath = null,
            //            UnitPrice = 8.55,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 29,
            //            MenuID = "26",
            //            ProductName = "Grilled Pork Vermicelli Noodle",
            //            Description = "Sliced marinated grilled pork with peanut and vegetables",
            //            ImagePath = null,
            //            UnitPrice = 8.55,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 30,
            //            MenuID = "27",
            //            ProductName = "Grilled Pork and Grilled Shrimp Vermicelli Noodle",
            //            Description = "Grilled pork and shrimp with peanut and vegetables",
            //            ImagePath = null,
            //            UnitPrice = 10.25,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 31,
            //            MenuID = "28",
            //            ProductName = "Grilled Pork and Egg Roll",
            //            Description = "Grilled Pork served with an egg roll",
            //            ImagePath = null,
            //            UnitPrice = 9.35,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 32,
            //            MenuID = "29",
            //            ProductName = "Grilled Shrimp, Pork and Egg Roll Vermicelli",
            //            Description = "Grilled Shrimp, Pork served with an egg roll",
            //            ImagePath = null,
            //            UnitPrice = 10.75,
            //            CategoryID = 4
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 33,
            //            MenuID = "30",
            //            ProductName = "Grilled Pork Chops",
            //            Description = "Pork Chop Marinated with Pho Nam Sauce",
            //            ImagePath = null,
            //            UnitPrice = 8.15,
            //            CategoryID = 5
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 34,
            //            MenuID = "31",
            //            ProductName = "Grilled Chicken",
            //            Description = "Chicken Marinated with Pho Nam Sauce",
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 5
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 35,
            //            MenuID = "32",
            //            ProductName = "House Rice Special",
            //            Description = "Grilled Pork Chops, fried egg, with combination meat casserole",
            //            ImagePath = null,
            //            UnitPrice = 9.50,
            //            CategoryID = 5
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 36,
            //            MenuID = "33",
            //            ProductName = "Combination Fried Rice",
            //            Description = "Pork, Chicken, Shrimp fried rice with carrots and celery",
            //            ImagePath = null,
            //            UnitPrice = 8.75,
            //            CategoryID = 5
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 37,
            //            MenuID = "34",
            //            ProductName = "Stir Fried Egg Noodle with choice of Beef, Pork or Chicken",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 9.25,
            //            CategoryID = 6
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 38,
            //            MenuID = "35",
            //            ProductName = "Stir Fried Rice Noodle with choice of Beef, Pork or Chicken",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 9.25,
            //            CategoryID = 6
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 39,
            //            MenuID = "36",
            //            ProductName = "Stir Fried Seafood with Egg Noodle",
            //            Description = "Combination of Shrimp, Squid, Scallops, and Fish Balls",
            //            ImagePath = null,
            //            UnitPrice = 11.25,
            //            CategoryID = 6
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 40,
            //            MenuID = "37",
            //            ProductName = "Stir Fried Seafood with Rice Noodle",
            //            Description = "Combination of Shrimp, Squid, Scallops, and Fish Balls",
            //            ImagePath = null,
            //            UnitPrice = 11.25,
            //            CategoryID = 6
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 41,
            //            MenuID = "38",
            //            ProductName = "Vegetable Egg Rolls",
            //            Description = "Carrot, Tofu, Bean Thread Noodle, Onions",
            //            ImagePath = null,
            //            UnitPrice = 3.25,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 42,
            //            MenuID = "39",
            //            ProductName = "Vegetable Spring Rolls",
            //            Description = "Tofu, Rice Noodle, and Assorted vegetable filling",
            //            ImagePath = null,
            //            UnitPrice = 3.45,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 43,
            //            MenuID = "40",
            //            ProductName = "Stir Fried Egg Noodle with Vegetables",
            //            Description = "Tofu, Broccoli, Carrot, Yu Choy, Cabbage, and Green Pepper",
            //            ImagePath = null,
            //            UnitPrice = 8.95,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 44,
            //            MenuID = "41",
            //            ProductName = "Stir Fried Rice Noodle with Vegetables",
            //            Description = "Tofu, Broccoli, Carrot, Yu Choy, Cabbage, and Green Pepper",
            //            ImagePath = null,
            //            UnitPrice = 8.95,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 45,
            //            MenuID = "42",
            //            ProductName = "Tapioca Noodle Soup with Vegetables",
            //            Description = "Rice Noodle Soup, carrots, tofu, mushroom, broccoli, and cabbage",
            //            ImagePath = null,
            //            UnitPrice = 8.25,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 46,
            //            MenuID = "43",
            //            ProductName = "Vegetarian Pho",
            //            Description = "Pho with tofu and mushroom",
            //            ImagePath = null,
            //            UnitPrice = 7.95,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 47,
            //            MenuID = "44",
            //            ProductName = "Vegetarian Fried Rice",
            //            Description = "Broccoli, Bean Sprouts, Carrot, Celery, Tofu and Egg",
            //            ImagePath = null,
            //            UnitPrice = 8.50,
            //            CategoryID = 7
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 48,
            //            MenuID = "45",
            //            ProductName = "Vietnamese Flan",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 3.25,
            //            CategoryID = 8
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 49,
            //            MenuID = "46",
            //            ProductName = "Sweet Rice Bean Pudding",
            //            Description = "Sweetened beans and coconut milk",
            //            ImagePath = null,
            //            UnitPrice = 3.25,
            //            CategoryID = 8
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 50,
            //            MenuID = "47",
            //            ProductName = "Soda",
            //            Description = "Pepsi, Diet Pepsi, Mountain Dew, Root Beer, Sierra Mist",
            //            ImagePath = null,
            //            UnitPrice = 1.50,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 51,
            //            MenuID = "48",
            //            ProductName = "Fresh Squeezed Lime Juice",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 2.25,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 52,
            //            MenuID = "49",
            //            ProductName = "Fresh Young Coconut",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 4.50,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 53,
            //            MenuID = "50",
            //            ProductName = "Orange Juice",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 2.25,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 54,
            //            MenuID = "51",
            //            ProductName = "Hot or Cold Soybean Milk",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 1.95,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 55,
            //            MenuID = "52",
            //            ProductName = "Hot or Cold Iced Tea",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 1.75,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 56,
            //            MenuID = "53",
            //            ProductName = "Thai Iced Tea",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 2.95,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 57,
            //            MenuID = "54",
            //            ProductName = "Vietnamese Hot Coffee",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 2.75,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 58,
            //            MenuID = "55",
            //            ProductName = "Vietnamese Ice Coffee",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 2.95,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 59,
            //            MenuID = "56",
            //            ProductName = "Vietnamese Hot Coffee with Condense Milk",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 3.25,
            //            CategoryID = 9
            //        },
            //        new MenuProduct
            //        {
            //            ProductID = 60,
            //            MenuID = "57",
            //            ProductName = "Vietnamese Iced Coffee with Condense Milk",
            //            Description = null,
            //            ImagePath = null,
            //            UnitPrice = 3.50,
            //            CategoryID = 9
            //        }
            //    }.ForEach(p => context.MenuProducts.Add(p));

        }
    }
}
