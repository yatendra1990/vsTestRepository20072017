using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class TestModel
    {
        private int id;
        private string name;

        public int ID {
            get { return id; }

            set { id = value; }
        }
        public string Name {

            get { return name; }
            set { name = value; }
        }
    }
}