﻿using System;
namespace Pirate
{
    public class Pirate : PirateAdventure
    {
        public Pirate()
        {

        }
        public string WillItWork { get; set; }
        public void Hi()
        {
            Name = GetUserResponse("What is your name?");

        }


    }
}
