using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_kursov
{
    public partial class picture : Component
    {
        public picture()
        {
            InitializeComponent();
        }

        public picture(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
