﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public List<Item> pitcher = new List<Item>();
        public double totalCosts;
        public double todaysCosts;
        public double totalProfits;
        public double todaysProfits;

        // constructor (SPAWNER)
        public Player()
        {
            name = null;
            inventory = new Inventory();
            wallet = new Wallet(20);
            recipe = new Recipe();
        }

        // member methods (CAN DO)

    }
}
