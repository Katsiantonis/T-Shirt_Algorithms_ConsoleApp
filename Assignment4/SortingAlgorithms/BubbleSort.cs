using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    class BubbleSort
    {
        public static void SizeColorFabricAscendingOrder(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void SizeColorFabricDescendingOrder(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void FabricAscendingOrder(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void FabricDescendingOrder(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }
    }
}


