﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name { get; set; }
        public LinkedList<Section> Sections { get; set; }

        Track(string name, SectionTypes[] sections)
        {

        }

        public Track()
        {
        }
    }
}