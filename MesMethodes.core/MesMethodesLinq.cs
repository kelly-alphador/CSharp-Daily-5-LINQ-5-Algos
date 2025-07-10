using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesMethodes.core
{
    public class MesMethodesLinq
    {
        //MON PREMIER JOUR
        /// <summary>
        /// Retourne une nouvelle liste contenant uniquement les nombres pairs de la liste d'origine.
        /// </summary>
        public List<int> AfficherNombresPairs(List<int> pairs)
        {
            var list = pairs.Where(x => x % 2 == 0).ToList();
            return list;
        }

        /// <summary>
        /// Retourne un objet contenant le min et le max d'une liste d'entiers.
        /// </summary>
        public MinMax TrouverMaxMin(List<int> list)
        {
            var resultat = new MinMax
            {
                Min = list.Min(),
                Max = list.Max()
            };
            return resultat;
        }

        /// <summary>
        /// Filtre une liste de chaînes et retourne celles dont la longueur est supérieure à n.
        /// </summary>
        public List<string> FiltrerParLongueur(List<string> list, int n)
        {
            var resultat = list.Where(l => l.Length > n).ToList();
            return resultat;
        }

        /// <summary>
        /// Retourne la liste des valeurs présentes plusieurs fois (doublons) dans la liste.
        /// </summary>
        public List<int> TrouverDoublons(List<int> list)
        {
            var resultat = list.GroupBy(x => x)
                               .Where(g => g.Count() > 1)
                               .Select(g => g.Key)
                               .ToList();
            return resultat;
        }

        /// <summary>
        /// Fusionne deux listes et retourne la liste des éléments communs aux deux listes (doublons globaux).
        /// </summary>
        public List<int> FusionnerListes(List<int> list1, List<int> list2)
        {
            var list = list1.Concat(list2).ToList();
            var resultat = list.GroupBy(x => x)
                               .Where(x => x.Count() > 1)
                               .Select(g => g.Key)
                               .ToList();
            return resultat;
        }
        //MON DEUXIEME JOUR
        /// <summary>
        /// Retourne la liste des éléments multiples de 3.
        /// </summary>
        public List<int> FiltreMultiple3(List<int> list)
        {
            var list1 = list.Where(x => x % 3 == 0).ToList();
            return list1;
        }

        /// <summary>
        /// Retourne une liste contenant la longueur de chaque chaîne dans la liste initiale.
        /// </summary>
        public List<int> LonguerChaine(List<string> list)
        {
            var list1 = list.Select(x => x.Length).ToList();
            return list1;
        }

        /// <summary>
        /// Retourne le premier élément pair trouvé dans la liste (ou 0 si aucun n'existe).
        /// </summary>
        public int PremierElementPaire(List<int> list)
        {
            var premierElement = list.FirstOrDefault(x => x % 2 == 0);
            return premierElement;
        }

        /// <summary>
        /// Retourne le mot le plus long dans une liste de chaînes.
        /// </summary>
        public string NomplusLongue(List<string> list)
        {
            var NomPlusLongue = list.OrderByDescending(x => x.Length).First();
            return NomPlusLongue;
        }

        /// <summary>
        /// Retourne la liste des premières lettres (clés) utilisées pour grouper les chaînes.
        /// </summary>
        public List<char> GroupeParLettre(List<string> list)
        {
            var list1 = list.GroupBy(x => x[0])
                            .Select(g => g.Key)
                            .ToList();
            return list1;
        }

    }
}
