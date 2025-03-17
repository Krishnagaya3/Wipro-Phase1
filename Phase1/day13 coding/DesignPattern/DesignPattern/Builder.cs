using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Builder
    {

        private Laptop _laptop = new Laptop();

        public Builder setProcessor(string processor)
        {
            _laptop.processor = processor;

            return this;
        }
        public Builder setRam(string ram)
        {
            _laptop.Ram = ram;

            return this;
        }

        public Laptop Build()
        { return _laptop; }

    }

}
