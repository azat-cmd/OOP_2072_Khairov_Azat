using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class FigureContainer
    {
        List<Figure> figures;
        public void Add(Figure figure)
        {
            figures.Add(figure);
        }
        public int Count { get { return figures.Count(); } }
        public Figure GetValue(int index)
        {
            return figures[index];
        }
        public int GetFigure(Figure figure)
        {
            for(int i=0;i<figures.Count();i++)
            {
                if (figures[i] == figure)
                    return i;
            }
            return -1;
        }

    }
}
