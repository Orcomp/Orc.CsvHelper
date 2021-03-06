﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Operation.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Csv.Tests.Entities
{
    using System;
    using System.Collections.Generic;

    public class Operation
    {
        public Operation()
        {
            Attributes  = new Dictionary<string, string>();
        }

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public double Quantity { get; set; }
        public bool Enabled { get; set; }

        public Dictionary<string, string> Attributes { get; private set; }
        #endregion

        public Operation Clone()
        {
            return new Operation
            {
                Id = Id,
                Name = Name,
                StartTime = StartTime,
                Duration = Duration,
                Quantity = Quantity,
                Enabled = Enabled,
            };
        }
    }
}