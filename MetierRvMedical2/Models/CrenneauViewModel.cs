using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class CrenneauViewModel
    {

        public CrenneauViewModel()
        {
           
        }


        public CrenneauViewModel(int duree, bool status, string heureDebut)
        {
            this.duree = duree;
            this.status = status;
            HeureDebut = heureDebut;
        }

        public int duree {  get; set; }
       public  bool status  { get; set; }
       public  string HeureDebut { get; set; }
        
       
    }
}
