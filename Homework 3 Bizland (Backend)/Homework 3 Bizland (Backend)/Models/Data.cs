using System.Collections.Generic;

namespace Homework_3_Bizland__Backend_.Models
{
    public class Data
    {
        public static List<Service> serviceList= new List<Service>
        {
            new Service {Id=1,IconUrl="bx bxl-dribbble",Title="Maqsud",Description="Zor oglandi"},
            new Service {Id=2,IconUrl="bx bx-file",Title="Amin",Description="Bomba oglandi"},
            new Service {Id=3,IconUrl="bx bx-tachometer",Title="Tural",Description="Zloy oglandi"},
            new Service {Id=4,IconUrl="bx bx-world",Title="Rahim",Description="Ejdaha oglandi"},
            new Service {Id=5,IconUrl="bx bx-slideshow",Title="Elvin",Description="Seviyye oglandi"},
            new Service {Id=6,IconUrl="bx bx-arch",Title="Reshad",Description="Zor oglan deyil"}
        };
        public static List<Team> teamList = new List<Team>
        {
            new Team {Id=1,ImgSrc="/assets/img/team/team-1.jpg",Name="Maqsud",Position="Aytisnikem qagas"},
            new Team {Id=2,ImgSrc="/assets/img/team/team-2.jpg",Name="Amin",Position="Dizaynereeem qagas"},
            new Team {Id=3,ImgSrc="/assets/img/team/team-3.jpg",Name="Tural",Position="Kriptocuyam qagas"},
            new Team {Id=4,ImgSrc="/assets/img/team/team-4.jpg",Name="Reshad",Position="Qaqas ozunsen ......"},
        };
    }
}
