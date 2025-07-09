using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesMethodes.core
{
    public class MesMethodesLinq
    {
        public List<int> AfficherNombresPairs(List<int> pairs)
        {
            var list = pairs.Where(x => x % 2 == 0).ToList();
            return list;
        }
        public MinMax TrouverMaxMin(List<int> list)
        {
            var resultat = new MinMax
            {
                Min = list.Min(),
                Max = list.Max()
            };
            return resultat;
        }
        public List<string> FiltrerParLongueur(List<string> list, int n)
        {
            var resultat = list.Where(l => l.Length > n).ToList();
            return resultat;
        }
        public List<int> TrouverDoublons(List<int> list)
        {
            //var resultat=list.Distinct().ToList();
            var resultat = list.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            return resultat;
        }
        public List<int> FusionnerListes(List<int> list1, List<int> list2)
        {
            var list = list1.Concat(list2).ToList();
            var resultat = list.GroupBy(x => x).Where(x => x.Count() > 1).Select(g => g.Key).ToList();
            return resultat;
        }
    }
}
