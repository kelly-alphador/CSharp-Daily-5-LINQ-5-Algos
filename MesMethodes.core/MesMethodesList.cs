using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesMethodes.core
{
    public class MesMethodesList
    {

        /// <summary>
        /// Inverse l'ordre des éléments dans la liste.
        /// </summary>
        public List<int> InverseListe(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count / 2; i++)
            {
                tmp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = tmp;
            }
            return list;
        }

        /// <summary>
        /// Calcule et retourne la somme de tous les éléments d'une liste.
        /// </summary>
        public int SommeListe(List<int> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i];
            }
            return s;
        }

        /// <summary>
        /// Recherche si un élément donné existe dans la liste.
        /// Retourne true s'il est trouvé, sinon false.
        /// </summary>
        public bool RechercherElement(List<int> list, int n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Trouve et retourne les éléments qui apparaissent plusieurs fois dans la liste.
        /// </summary>
        public List<int> TrouverDoublons(List<int> list)
        {
            List<int> result = new List<int>();
            int tmp;
            bool test;
            for (int i = 0; i < list.Count; i++)
            {
                tmp = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (tmp == list[j])
                    {
                        test = false;
                        for (int k = 0; k < result.Count; k++)
                        {
                            if (result[k] == tmp)
                            {
                                test = true;
                                break;
                            }
                        }
                        if (test == false)
                        {
                            result.Add(tmp);
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Fusionne deux listes en une seule et enlève les doublons.
        /// </summary>
        public List<int> FusionnerListes(List<int> list1, List<int> list2)
        {
            List<int> ListPasDoublons = new List<int>();
            List<int> list = new List<int>();
            bool test;
            for (int i = 0; i < list1.Count; i++)
            {
                list.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                list.Add(list2[i]);
            }
            ListPasDoublons.Add(list[0]);
            for (int i = 1; i < list.Count; i++)
            {
                test = false;
                for (int k = 0; k < ListPasDoublons.Count; k++)
                {
                    if (list[i] == ListPasDoublons[k])
                    {
                        test = true;
                        break;
                    }
                }
                if (test == false)
                {
                    ListPasDoublons.Add(list[i]);
                }
            }
            return ListPasDoublons;
        }

        /// <summary>
        /// Calcule et retourne la moyenne des valeurs d'une liste.
        /// </summary>
        public int Moyenne(List<int> list)
        {
            int s = SommeListe(list);
            return s / list.Count;
        }

        /// <summary>
        /// Retourne une liste contenant uniquement les éléments qui apparaissent une seule fois.
        /// </summary>
        public List<int> Element_Unique(List<int> list)
        {
            int tmp;
            int count = 0;
            List<int> list2 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                count = 0;
                tmp = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (tmp == list[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    list2.Add(list[i]);
                }
            }
            return list2;
        }

        /// <summary>
        /// Retourne un objet contenant le minimum et le maximum de la liste.
        /// </summary>
        public MinMax MinAndMax(List<int> list)
        {
            int min = list[0];
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            return new MinMax
            {
                Min = min,
                Max = max
            };
        }

        /// <summary>
        /// Trie la liste en ordre croissant (algorithme du tri à bulles).
        /// </summary>
        public List<int> SortCroisant(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Trie la liste en ordre décroissant (algorithme du tri à bulles).
        /// </summary>
        public List<int> SortDecroisant(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }
            return list;
        }
        public int produit(List<int> list) 
        {
            int p = 1;
            for(int i = 0;i < list.Count;i++)
            {
                p=p*list[i];
            }
            return p;
        }

    }
}
