﻿using PustokTemplateTask.Models;

namespace PustokTemplateTask.ModelViews
{
    public class PustokVM
    {
        public ICollection<Slider> Sliders { get; set; }

        public ICollection<Feature> Features { get; set;}
    }
}
