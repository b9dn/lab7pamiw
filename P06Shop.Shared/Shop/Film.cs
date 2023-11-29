﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Shop
{
    // data annotations 
    //public class Film
    //{
    //    [Key]
    //    public int Code { get; set; }

    //    public int Id { get; set; }

    //    [MaxLength(100)]
    //    public string Title { get; set; }

    //    public string Description { get; set; }
    //}

    // fluent api 
    public class Film : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public string Title { get; set; }


        public string Barcode { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }


        private string _description;


        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Category? Category { get; set; }
        public int? CategoryId { get; set; }

        public int? FilmDetailsId { get; set; }

        public FilmDetails? FilmDetails { get; set;}

        public ICollection<FilmSuppliers>? FilmSuppliers { get; set; }
    }
}
