﻿using System.ComponentModel.DataAnnotations;

namespace EntryNow.WebApp.Models
{
    public class DropDownSettings
    {
        public int Id { get; set; }
        public string SurnameName { get; set; }
    }
    public class DropDownSettings_UC
    {
        public int Id { get; set; }
        public string UnionCounsilName { get; set; }
    }
    public class DropDownSettings_Village
    {
        public int Id { get; set; }
        public string VillageName { get; set; }
    }

    //public class DropDownSettings_ViewModel
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    public string SurnameName { get; set; }
    //}
}
