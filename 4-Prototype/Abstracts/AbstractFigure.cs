using _4_Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prototype.Abstracts
{
    public abstract class AbstractFigure : IFigure
    {
        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public IFigure DeepClone()
        {
            IFigure figure;

            using MemoryStream tempStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter(null,
                new StreamingContext(StreamingContextStates.Clone));
            binaryFormatter.Serialize(tempStream, this);
            tempStream.Position = 0;
            figure = (IFigure)binaryFormatter.Deserialize(tempStream);

            return figure;
        }

        public abstract void GetInfo();
    }
}
