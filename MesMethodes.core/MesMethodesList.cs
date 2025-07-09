using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesMethodes.core
{
    public class MesMethodesList
    {
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
        public int SommeListe(List<int> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                s = s + list[i];
            }
            return s;
        }
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
        public List<int> TrouverDoublons(List<int> list)
        {
            List<int> result = new List<int>();
            int tmp;
            bool test;
            for (int i = 0; i < list.Count; i++)
            {
                tmp = list[i];
                for (int j = i + 1; j < list.Count; j++)
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
    }
}
