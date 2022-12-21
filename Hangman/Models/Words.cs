using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Hangman.Models
{
    [Serializable]
    public class Words
    {
        [XmlArray]
        public ObservableCollection<string> Cars { get; set; }
        [XmlArray]
        public ObservableCollection<string> Mountains { get; set; }
        [XmlArray]
        public ObservableCollection<string> Movies { get; set; }
        [XmlArray]
        public ObservableCollection<string> Rivers { get; set; }
        [XmlArray]
        public ObservableCollection<string> States { get; set; }

        public Words()
        {
            Cars = new ObservableCollection<string>();
            Mountains = new ObservableCollection<string>();
            Movies = new ObservableCollection<string>();
            Rivers = new ObservableCollection<string>();
            States = new ObservableCollection<string>();
        }

        public void AddWords()
        {
            Cars = new ObservableCollection<string>();
            Cars.Add("ФОРД");
            Cars.Add("МЕРСЕДЕС");
            Cars.Add("АУДИ");
            Cars.Add("ОПЕЛЬ");
            Cars.Add("ДАСИА");
            Cars.Add("ФОЛЬКСВАГЕН");
            Cars.Add("ФЕРРАРИ");
            Cars.Add("ХОНДА");
            Cars.Add("СУБАРУ");
            Cars.Add("ТОЙОТА");
            Cars.Add("ХЁНДАЙ");
            Cars.Add("РЕНО");
            Cars.Add("РЕНДЖ РОВЕР");
            Cars.Add("ЛЭНД РОВЕР");
            Cars.Add("ПИЖО");
            Cars.Add("АСТОН МАРТИН");
            Cars.Add("ЛАМБОРГИНИ");
            Cars.Add("БУГАТТИ");
            Cars.Add("БЕНТЛИ");
            Cars.Add("ПОРШЕ");

            Mountains = new ObservableCollection<string>();
            Mountains.Add("ГИМАЛАИ");
            Mountains.Add("РОКИ");
            Mountains.Add("СЬЕРРА НЕВАДА");
            Mountains.Add("КАРПАТЫ");
            Mountains.Add("АЛЬПЫ");
            Mountains.Add("ПИРЕНЕИ");
            Mountains.Add("АПЕННИНЫ");
            Mountains.Add("УРАЛЬСКИЕ");
            Mountains.Add("БАЛКАНСКИЕ");
            Mountains.Add("КАВКАЗСКИЕ");
            Mountains.Add("СКАНДИНАВСКИЕ");
            Mountains.Add("ПЕННИНСКИЕ");
            Mountains.Add("ФУДЗИ");
            Mountains.Add("КИЛИМАНДЖАРО");
            Mountains.Add("МОНБЛАН");
            Mountains.Add("ОЛИМПУС");
            Mountains.Add("ЭВЕРЕСТ");
            Mountains.Add("АПУСЕНИ");
            Mountains.Add("ФЭГЭРАШ");
            Mountains.Add("БУЧЕДЖИ");

            Movies = new ObservableCollection<string>();
            Movies.Add("ВИКИНГИ");
            Movies.Add("ОСТРЫЕ КОЗЫРЬКИ");
            Movies.Add("ЛЮЦИФЕР");
            Movies.Add("БУМАЖНЫЙ ДОМ");
            Movies.Add("ЧЕРНОБЫЛЬ");
            Movies.Add("ДРУЗЬЯ");
            Movies.Add("ХОЛОДНОЕ СЕРДЦЕ");
            Movies.Add("ОТРЯД САМОУБИЙЦ");
            Movies.Add("БЭТМЕН");
            Movies.Add("СУПЕРМЕН");
            Movies.Add("ЧЕЛОВЕК ПАУК");
            Movies.Add("КОРОЛЬ ЛЕВ");
            Movies.Add("ДЖУМАНДЖИ");
            Movies.Add("РИВЕРДЕЙЛ");
            Movies.Add("ВО ВСЕ ТЯЖКИЕ");
            Movies.Add("МСТИТЕЛИ");
            Movies.Add("БИЧИ В МАЙАМИ");
            Movies.Add("МИРАЖ");
            Movies.Add("ЗВЕЗДНЫЕ ВОЙНЫ");
            Movies.Add("ЗВЕЗДНЫЙ ПУТЬ");

            Rivers = new ObservableCollection<string>();
            Rivers.Add("ДУНАЙ");
            Rivers.Add("ВОЛГА");
            Rivers.Add("НИЛ");
            Rivers.Add("ТЕМЗА");
            Rivers.Add("СЕНА");
            Rivers.Add("ПРУТ");
            Rivers.Add("МАРОШ");
            Rivers.Add("ОЛТ");
            Rivers.Add("ТИБР");
            Rivers.Add("АМАЗОНКА");
            Rivers.Add("ТИМИШ");
            Rivers.Add("МИССИСИПИ");
            Rivers.Add("МИССУРИ");
            Rivers.Add("СЕНА");
            Rivers.Add("РЕЙН");
            Rivers.Add("ЭЛЬБА");
            Rivers.Add("МАЙН");
            Rivers.Add("ГАНГ");
            Rivers.Add("БРАХМАПУТРА");
            Rivers.Add("НИАГАРА");

            States = new ObservableCollection<string>();
            States.Add("РОССИЯ");
            States.Add("КИТАЙ");
            States.Add("ЯПОНИЯ");
            States.Add("ГЕРМАНИЯ");
            States.Add("ВЕЛИКОБРИТАНИЯ");
            States.Add("ФРАНЦИЯ");
            States.Add("НИДЕРЛАНДЫ");
            States.Add("ЧЕХИЯ");
            States.Add("ХОРВАТИЯ");
            States.Add("СЛОВАКИЯ");
            States.Add("США");
            States.Add("СЛОВЕНИЯ");
            States.Add("БРАЗИЛИЯ");
            States.Add("АРГЕНТИНА");
            States.Add("КОЛУМБИЯ");
            States.Add("МЕКСИКА");
            States.Add("КАНАДА");
            States.Add("АВСТРАЛИЯ");
            States.Add("ИСПАНИЯ");
            States.Add("СЕРБИЯ");
        }
    }
}
