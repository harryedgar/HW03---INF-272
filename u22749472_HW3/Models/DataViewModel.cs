using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22749472_HW3.Models
{
    public class DataViewModel
    {

        //GET
        public IEnumerable<author> authors { get; set;}
        public IEnumerable<book> books { get; set;}
        public IEnumerable<borrow> borrows { get; set;}
        public IEnumerable<student> students { get; set;}
        public IEnumerable<type> types { get; set;}

        //Post
        public author newAuthor { get; set;}
        public book newBook { get; set;}
        public borrow newBorrow { get; set;}
        public student newStudent { get; set;}
        public type newType { get; set;}


        ////GET
        //public IPagedList<author> authors { get; set; }
        //public IPagedList<book> books { get; set; }
        //public IPagedList<borrow> borrows { get; set; }
        //public IPagedList<student> students { get; set; }
        //public IPagedList<type> types { get; set; }


    }
}