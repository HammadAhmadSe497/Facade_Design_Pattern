// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program{
    static void Main(string[] args){
       CarFacade mustang = new CarFacade(); 
         mustang.createCar("V8","Convertible","Leather Seats");
            mustang.display();
    }
}
